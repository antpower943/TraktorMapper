using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TraktorMapper.Code.Objects;
using TraktorMapper.Code.Enum;

namespace TraktorMapper.Code.Process.TSI
{
    class TSISave
    {
        public static void Save(List<TSIFile> files, string path)
        {
            WriteToFile(EncodeBase(BuildRawFile(files)), path);
        }

        private static List<byte> BuildRawFile(List<TSIFile> Files)
        {
            List<byte> bFiles = new List<byte>();

            foreach (TSIFile f in Files)
            {
                // One mapping

                #region DVST
                //List<byte> test = new List<byte>();

                //test.AddRange(I2B(20));
                //test.AddRange(I2B(123456789));

                List<byte> DVST = new List<byte>();

                DVST.AddRange(S2B("DVST"));
                DVST.AddRange(I2B(20));
                DVST.AddRange(I2B(1));
                DVST.AddRange(I2B(0));
                DVST.AddRange(I2B(0));
                DVST.AddRange(I2B(0));
                DVST.AddRange(I2B(0));

                #endregion

                #region DCBM
                List<byte> DCBM0 = new List<byte>();
                List<byte> DCBM = new List<byte>();
                int DCBM_entries = 0;
                int DCBM_chars = 0;

                foreach (TSIControl c in f.Controls)
                {
                    DCBM0.AddRange(S2B("DCBM"));
                    DCBM0.AddRange(I2B(8 + (c.Note.Length * 2)));
                    DCBM0.AddRange(I2B(c.ID()));
                    DCBM0.AddRange(I2B(c.Note.Length));
                    DCBM0.AddRange(S2B2(c.Note));
                    DCBM_entries += 1;
                    DCBM_chars += 16 + (c.Note.Length * 2);
                }

                DCBM.AddRange(S2B("DCBM"));
                DCBM.AddRange(I2B(4 + DCBM_chars));
                DCBM.AddRange(I2B(DCBM_entries));
                DCBM.AddRange(DCBM0);

                #endregion

                #region DDCB => CMAS = CMAI & CMAD

                List<byte> CMAI = new List<byte>();
                int CMAI_entries = 0;
                int CMAI_chars = 0;

                foreach (TSIControl c in f.Controls)
                {
                    CMAI.AddRange(S2B("CMAI"));
                    CMAI.AddRange(I2B(140 + (c.Comment().Length * 2)));
                    CMAI.AddRange(I2B(c.ID()));

                    if (c.IO() == IOState.Input) CMAI.AddRange(I2B(0));
                    else if (c.IO() == IOState.Output) CMAI.AddRange(I2B(1));

                    CMAI.AddRange(I2B(c.ActionID()));

                    CMAI.AddRange(S2B("CMAD"));
                    CMAI.AddRange(I2B(120 + (c.Comment().Length * 2)));
                    CMAI.AddRange(I2B(4));
                    CMAI.AddRange(I2B(c.ControllerType()));
                    CMAI.AddRange(I2B(c.Interaction()));

                    if (c.Deck() == DeckFocus.DeckA) CMAI.AddRange(I2B(0));
                    else if (c.Deck() == DeckFocus.DeckB) CMAI.AddRange(I2B(1));
                    else if (c.Deck() == DeckFocus.DeckC) CMAI.AddRange(I2B(2));
                    else if (c.Deck() == DeckFocus.DeckD) CMAI.AddRange(I2B(3));
                    else CMAI.AddRange(I2B(197370));

                    CMAI.AddRange(I2B(0));
                    CMAI.AddRange(I2B(BOOL2I(c.Inverted())));
                    CMAI.AddRange(I2B(BOOL2I(c.SoftTakeover())));
                    CMAI.AddRange(I2B(c.RotarySensitivity()));
                    CMAI.AddRange(I2B(c.RotaryAcceleration()));
                    CMAI.AddRange(I2B(c.ButtonOrElse()));
                    CMAI.AddRange(I2B(1));
                    CMAI.AddRange(I2B(c.InteractionValue()));
                    CMAI.AddRange(I2B(c.Comment().Length));

                    if (c.Comment().Length != 0) CMAI.AddRange(S2B2(c.Comment()));

                    CMAI.AddRange(I2B(c.Modifier1().ID));
                    CMAI.AddRange(I2B(c.Modifier1().Parameter));
                    CMAI.AddRange(I2B(c.Modifier1().Value));

                    CMAI.AddRange(I2B(c.Modifier2().ID));
                    CMAI.AddRange(I2B(c.Modifier2().Parameter));
                    CMAI.AddRange(I2B(c.Modifier2().Value));

                    CMAI.AddRange(I2B(1));
                    CMAI.AddRange(I2B(c.ControllerRangeMin()));
                    CMAI.AddRange(I2B(1));
                    CMAI.AddRange(I2B(c.ControllerRangeMax()));

                    CMAI.AddRange(I2B(c.MIDIRangeMin()));
                    CMAI.AddRange(I2B(c.MIDIRangeMax()));
                    CMAI.AddRange(I2B(0));
                    CMAI.AddRange(I2B(BOOL2I(c.Blend())));
                    CMAI.AddRange(I2B(1));
                    CMAI.AddRange(I2B(1));
                    CMAI.AddRange(I2B(0));

                    CMAI_chars += 140 + (c.Comment().Length * 2) + 8;
                    CMAI_entries += 1;
                }

                //CMAS

                List<byte> CMAS = new List<byte>();

                CMAS.AddRange(S2B("CMAS"));
                CMAS.AddRange(I2B(CMAI_chars + 4));
                CMAS.AddRange(I2B(CMAI_entries));
                CMAS.AddRange(CMAI);

                //DDCB

                List<byte> DDCB = new List<byte>();

                DDCB.AddRange(S2B("DDCB"));
                DDCB.AddRange(I2B(DCBM.Count + CMAS.Count/*DCBM_chars + 16 + CMAI_chars*/));
                DDCB.AddRange(CMAS);
                DDCB.AddRange(DCBM);

                #endregion

                #region DDDC => DDCI, DDCO & DCDT

                List<byte> DCDT = new List<byte>();
                int i = 0;

                foreach (IO io in f.IOList)
                {
                    if (io.Input == IOState.Output) break;

                    DCDT.AddRange(S2B("DCDT"));
                    DCDT.AddRange(I2B(24 + io.Channel.Length));
                    DCDT.AddRange(I2B(io.Channel.Length));

                    if (io.Channel.Length != 0) DCDT.AddRange(S2B2(io.Channel));

                    DCDT.AddRange(I2B(7)); // IO
                    DCDT.AddRange(I2B(0));
                    DCDT.AddRange(I2B(82626));
                    DCDT.AddRange(I2B(1));
                    DCDT.AddRange(I2B(197370));

                    i++;
                }

                List<byte> DDCI = new List<byte>();

                DDCI.AddRange(S2B("DDCI"));
                DDCI.AddRange(I2B(DCDT.Count + 4));
                DDCI.AddRange(I2B(i));
                DDCI.AddRange(DCDT);

                DCDT.Clear();

                for (int j = i; j < f.IOList.Count; j++)
                {
                    DCDT.AddRange(S2B("DCDT"));
                    DCDT.AddRange(I2B(24 + f.IOList[j].Channel.Length));
                    DCDT.AddRange(I2B(f.IOList[j].Channel.Length));

                    if (f.IOList[j].Channel.Length != 0) DCDT.AddRange(S2B2(f.IOList[j].Channel));

                    DCDT.AddRange(I2B(f.IOList[j].InputInt)); // IO
                    DCDT.AddRange(I2B(0));
                    DCDT.AddRange(I2B(82626));
                    DCDT.AddRange(I2B(1));
                    DCDT.AddRange(I2B(197370));
                }

                List<byte> DDCO = new List<byte>();

                DDCO.AddRange(S2B("DDCO"));
                DDCO.AddRange(I2B(DCDT.Count + 4));
                DDCO.AddRange(I2B(f.IOList.Count - i));
                DDCO.AddRange(DCDT);

                List<byte> DDDC = new List<byte>();

                DDDC.AddRange(S2B("DDDC"));
                DDDC.AddRange(I2B(DDCI.Count + DDCO.Count));
                DDDC.AddRange(DDCI);
                DDDC.AddRange(DDCO);
                DDDC.AddRange(DDCB);

                #endregion

                #region DDPT

                List<byte> DDPT = new List<byte>();

                DDPT.AddRange(S2B("DDPT"));
                DDPT.AddRange(I2B(8 + (f.PInput.Length * 2) + (f.POutput.Length * 2)));
                DDPT.AddRange(I2B(f.PInput.Length));
                DDPT.AddRange(S2B2(f.PInput));
                DDPT.AddRange(I2B(f.POutput.Length));
                DDPT.AddRange(S2B2(f.POutput));

                #endregion

                #region DDIC

                List<byte> DDIC = new List<byte>();

                DDIC.AddRange(S2B("DDIC"));
                DDIC.AddRange(I2B(4 + (f.PFileComment.Length * 2)));
                DDIC.AddRange(I2B(f.PFileComment.Length));
                DDIC.AddRange(S2B2(f.PFileComment));

                #endregion

                #region DDIV

                List<byte> DDIV = new List<byte>();

                DDIV.AddRange(S2B("DDIV"));
                DDIV.AddRange(I2B(8 + (f.PConfigVersion.Length * 2)));
                DDIV.AddRange(I2B(f.PConfigVersion.Length));
                DDIV.AddRange(S2B2(f.PConfigVersion));
                DDIV.AddRange(I2B(f.PBuildVersion));

                #endregion

                #region DDIF

                List<byte> DDIF = new List<byte>();

                DDIF.AddRange(S2B("DDIF"));
                DDIF.AddRange(I2B(4));
                DDIF.AddRange(I2B(f.PDeviceTarget));

                #endregion

                // Mapping subfile-specific

                #region DDAT

                List<byte> DDAT = new List<byte>();

                DDAT.AddRange(S2B("DDAT"));
                DDAT.AddRange(I2B(DDIF.Count + DDIV.Count + DDIC.Count + DDPT.Count + DDDC.Count + DVST.Count));
                DDAT.AddRange(DDIF);
                DDAT.AddRange(DDIV);
                DDAT.AddRange(DDIC);
                DDAT.AddRange(DDPT);
                DDAT.AddRange(DDDC);
                DDAT.AddRange(DVST);

                #endregion

                #region DEVI

                List<byte> DEVI = new List<byte>();

                DEVI.AddRange(S2B("DEVI"));
                DEVI.AddRange(I2B(4 + (f.PType.Length * 2) + DDAT.Count));
                DEVI.AddRange(I2B(f.PType.Length));
                DEVI.AddRange(S2B2(f.PType));
                DEVI.AddRange(DDAT);

                #endregion

                bFiles.AddRange(DEVI);
            }

            // Entire File

            #region DEVS

            List<byte> DEVS = new List<byte>();

            DEVS.AddRange(S2B("DEVS"));
            DEVS.AddRange(I2B(bFiles.Count));
            DEVS.AddRange(I2B(1));
            DEVS.AddRange(bFiles);

            #endregion

            #region DIOI

            List<byte> DIOI = new List<byte>();

            DIOI.AddRange(S2B("DIOI"));
            DIOI.AddRange(I2B(4));
            DIOI.AddRange(I2B(1));

            #endregion

            #region DIOM

            List<byte> DIOM = new List<byte>();

            DIOM.AddRange(S2B("DIOM"));
            DIOM.AddRange(I2B(DIOI.Count + DEVS.Count));
            DIOM.AddRange(DIOI);
            DIOM.AddRange(DEVS);

            #endregion

            return DIOM;
        }

        private static byte[] EncodeBase(List<byte> ba)
        {
            string output = "";
            int cnt = 0;

            while (cnt != 2)
            {
                try
                {
                    output = System.Convert.ToBase64String(ba.ToArray());
                    break;
                }
                catch (FormatException)
                {
                    ba.AddRange(S2B("="));
                    cnt++;
                }
            }

            return S2B(output);
        }

        private static void WriteToFile(byte[] output, string path)
        {
            List<byte> write = new List<byte>();

            write.AddRange(S2B("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\" ?>\n"));
            write.AddRange(S2B("<NIXML><TraktorSettings><Entry Name=\"DeviceIO.Config.Controller\" Type=\"3\" Value=\""));
            write.AddRange(output);
            write.AddRange(S2B("\"></Entry>\n"));
            write.AddRange(S2B("<Entry Name=\"Flavour\" Type=\"1\" Value=\"-1\"></Entry>\n"));
            write.AddRange(S2B("<Entry Name=\"Version\" Type=\"1\" Value=\"0\"></Entry>\n"));
            write.AddRange(S2B("</TraktorSettings>\n"));
            write.AddRange(S2B("</NIXML>\n"));

            System.IO.File.WriteAllBytes(path, write.ToArray());

            //using (StreamWriter w = new StreamWriter(path))
            //{


            //    try
            //    {
            //        w.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\" ?>");
            //        w.Write("<NIXML><TraktorSettings><Entry Name=\"DeviceIO.Config.Controller\" Type=\"3\" Value=\"");


            //        w.WriteLine("\"></Entry>");
            //        w.WriteLine("<Entry Name=\"Flavour\" Type=\"1\" Value=\"-1\"></Entry>");
            //        w.WriteLine("<Entry Name=\"Version\" Type=\"1\" Value=\"0\"></Entry>");
            //        w.WriteLine("</TraktorSettings>");
            //        w.WriteLine("</NIXML>");
            //    }
            //    catch (IndexOutOfRangeException e)
            //    {
            //        MessageBox.Show("Error: File is not a valid TSI-file");
            //        // ERROR_HANDLER
            //    }
            //}
        }

        /// <summary>
        /// String 2 Byte
        /// </summary>
        /// <param name="b">string</param>
        /// <returns>bytearray</returns>
        private static byte[] S2B2(string s)
        {
            byte[] ba = Encoding.UTF8.GetBytes(s);
            List<byte> bl = new List<byte>();

            foreach (byte b in ba)
            {
                bl.Add(0);
                bl.Add(b);
            }

            return bl.ToArray();
        }

        private static byte[] S2B(string s)
        {
            return Encoding.UTF8.GetBytes(s);
        }

        private static byte[] I2B(int i)
        {
            //return Encoding.UTF8.GetBytes(i.ToString());

            int b0 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;

            while (i != 0)
            {
                if (i > 16777216)
                {
                    i -= 16777216;
                    b0 += 1;
                }
                else if (i > 65536)
                {
                    i -= 65536;
                    b1 += 1;
                }
                else if (i > 256)
                {
                    i -= 256;
                    b2 += 1;
                }
                else
                {
                    b3 = i;
                    i = 0;
                }
            }

            byte[] returnvalue = new byte[4];
            returnvalue[0] = (byte)b0;
            returnvalue[1] = (byte)b1;
            returnvalue[2] = (byte)b2;
            returnvalue[3] = (byte)b3;

            return returnvalue;
        }

        private static int BOOL2I(bool b)
        {
            if (b) return 1;
            else return 0;
        }
    }
}
