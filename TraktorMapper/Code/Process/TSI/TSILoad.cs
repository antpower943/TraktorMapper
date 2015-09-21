using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TraktorMapper.Code.Objects;
using System.IO;
using System.Windows.Forms;
using TraktorMapper.Code.Enum;

namespace TraktorMapper.Code.Process.TSI
{
    static class TSILoad
    {
        public static List<TSIFile> GetTSI(string path)
        {
            return CreateFileMethod(TSILoad.ReadFromFile(path));
        }



        /// <summary>
        /// Reads from normal TSI-file, and decodes the base64
        /// </summary>
        /// <param name="file">Complete filepath, from drive to extension</param>
        /// <returns>Decoded base64-part of the file, in bytes</returns>
        private static byte[] ReadFromFile(string file)
        {
            byte[] value = new byte[0];

            using (StreamReader r = new StreamReader(file))
            {
                try
                {
                    value = DecodeBase(r.ReadToEnd().Replace("<Entry Name=\"DeviceIO.Config.Controller\" Type=\"3\" Value=\"", "æ").Split('æ')[1].Replace("\"></Entry>", "æ").Split('æ')[0]);
                }
                catch (IndexOutOfRangeException e)
                {
                    MessageBox.Show("Error: File is not a valid TSI-file");
                    // ERROR_HANDLER

                    throw new Exception("null");
                }
            }

            return value;
        }

        /// <summary>
        /// Takes the decoded bytes and converts it to a TSIFile object list (for each file contained within)
        /// </summary>
        /// <param name="ba">the from base64 converted bytes</param>
        /// <returns></returns>
        private static List<TSIFile> CreateFileMethod(byte[] ba)
        {
            string header1 = "";
            int strLength = 0;
            TSIFile tempFile = null;
            List<TSIFile> Files = new List<TSIFile>();

            List<IO> ioList = null;
            List<TSIControl> ctrlList = null;

            string type = "";
            int devicetarget = 0;
            string version = "";
            int versionextra = 0;
            string comment = "";
            string input = "";
            string output = "";
            int loop = 0;

            for (int i = 0; i <= ba.Length - 3; )
            {
                // First 4 bytes to determine header (if it is a header)
                if (IsEven(i) /*&& (i >= 8)*/&& i <= (ba.Length - 4))
                {
                    header1 = B2S(ba[i]) + B2S(ba[i + 1]) + B2S(ba[i + 2]) + B2S(ba[i + 3]);

                    i += 4;
                }
                else i++;

                if (header1 == "DEVI")
                {
                    i += 4;
                    strLength = ConvertToDecimal(ba, i);
                    i += 4;
                    type = StringReader(ba, i, strLength);
                    i += strLength * 2;
                }
                else if (header1 == "DDIF")
                {
                    i += 4;
                    devicetarget = ConvertToDecimal(ba, i);
                    i += 4;

                }
                else if (header1 == "DDIV")
                {
                    i += 4;
                    strLength = ConvertToDecimal(ba, i);
                    i += 4;
                    version = StringReader(ba, i, strLength);
                    i += strLength * 2;
                    versionextra = ConvertToDecimal(ba, i);
                    i += 4;
                }
                else if (header1 == "DDIC")
                {
                    i += 4;
                    strLength = ConvertToDecimal(ba, i);
                    i += 4;
                    comment = StringReader(ba, i, strLength);
                    i += strLength * 2;
                }
                else if (header1 == "DDPT")
                {
                    i += 4;
                    strLength = ConvertToDecimal(ba, i);
                    i += 4;
                    input = StringReader(ba, i, strLength);
                    i += strLength * 2;
                    strLength = ConvertToDecimal(ba, i);
                    i += 4;
                    output = StringReader(ba, i, strLength);
                    i += strLength * 2;
                }
                else if (header1 == "DDDC")
                {
                    tempFile = new TSIFile(type, devicetarget, version, versionextra, comment, input, output);
                    i += 4;
                }
                else if ((header1 == "DDCI") || (header1 == "DDCO"))
                {
                    ioList = new List<IO>();

                    i += 4;
                    loop = ConvertToDecimal(ba, i);
                    i += 4;

                    for (int l = 0; l < loop; l++)
                    {
                        ReturnIO rio;

                        if (header1 == "DDCI") rio = IOLoop(ba, i, true);
                        else rio = IOLoop(ba, i, false);
                        i = rio.i();

                        ioList.Add(rio.IO());
                    }

                    tempFile.IOList = ioList;
                }
                else if (header1 == "CMAS")
                {
                    ctrlList = new List<TSIControl>();

                    i += 4;
                    loop = ConvertToDecimal(ba, i);
                    i += 4;

                    for (int l = 0; l < loop; l++)
                    {
                        ReturnControl rc = GetControl(ba, i);
                        i = rc.i();

                        ctrlList.Add(rc.Ctrl());
                    }

                    tempFile.Controls = ctrlList;
                }
                else if (header1 == "DCBM")
                {
                    i += 4;
                    loop = ConvertToDecimal(ba, i);
                    i += 4;

                    for (int k = 0; k < loop; k++)
                    {
                        i += 8;
                        int ID = ConvertToDecimal(ba, i);
                        i += 4;
                        strLength = ConvertToDecimal(ba, i);
                        i += 4;
                        string Note = StringReader(ba, i, strLength);
                        i += strLength * 2;

                        for (int j = 0; j < tempFile.Controls.Count; j++)
                        {
                            if ((tempFile.Controls[j].ID() == ID) && (tempFile.Controls[j].Note == ""))
                            {
                                // Connection found
                                if (Note == "") Note = "n/a";
                                tempFile.Controls[j].Note = Note;
                                break;
                            }
                        }
                    }
                }
                else if (header1 == "DVST")
                {
                    i += 24;

                    // Tempfile Check
                    List<int> iadel = new List<int>();

                    //foreach (Sub.Control c in tempFile.Controls)
                    //{
                    //    if ((c.Deck() != DeckFocus.DeckA) && (c.Deck() != DeckFocus.DeckB) && (c.Deck() != DeckFocus.DeckC) && (c.Deck() != DeckFocus.DeckD) && (c.Deck() != DeckFocus.Target))
                    //    {
                    //        // Delete entry
                    //        iadel.Add(check);
                    //    }

                    //    check++;

                    //    if (check == tempFile.Controls.Count)
                    //    { }
                    //}

                    for (int check = 0; check < tempFile.Controls.Count; check++)
                    {
                        TSIControl c = tempFile.Controls[check];

                        if ((c.Deck() != DeckFocus.DeckA) && (c.Deck() != DeckFocus.DeckB) && (c.Deck() != DeckFocus.DeckC) && (c.Deck() != DeckFocus.DeckD) && (c.Deck() != DeckFocus.Target))
                        {
                            // Delete entry
                            iadel.Add(check);
                        }
                    }

                    iadel.Reverse();

                    if (iadel.Count != 0)
                    {
                        foreach (int idel in iadel)
                        {
                            tempFile.Controls.RemoveAt(idel);
                        }

                        MessageBox.Show("Some entries have been removed because of incomplete rows");
                    }

                    Files.Add(tempFile);
                }
            }

            return Files;
        }

        /// <summary>
        /// Check if an integer is even or not
        /// </summary>
        /// <param name="pos">the integer to be checked</param>
        /// <returns>true (Even) / false (Uneven)</returns>
        private static bool IsEven(int pos)
        {
            if ((pos % 2) == 0) return true;
            else return false;
        }

        /// <summary>
        /// Decodes Base64-strings to byte-arrays
        /// </summary>
        /// <param name="encodedData">Base64-string</param>
        /// <returns>Base64-part of the file, in bytes</returns>
        private static byte[] DecodeBase(string encodedData)
        {
            byte[] encodedDataAsBytes = new byte[0];
            int cnt = 0;

            while (cnt != 2)
            {
                try
                {
                    encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
                    break;
                }
                catch (FormatException)
                {
                    encodedData += "=";
                    cnt++;
                }
            }

            return encodedDataAsBytes;
        }

        #region B2S

        /// <summary>
        /// Byte 2 String
        /// </summary>
        /// <param name="b">Single byte</param>
        /// <returns>string</returns>
        private static string B2S(byte b)
        {
            byte[] ba = { b };
            return B2S(ba);
        }

        /// <summary>
        /// Byte 2 String
        /// </summary>
        /// <param name="b">bytearray</param>
        /// <returns>string</returns>
        private static string B2S(byte[] b)
        {
            return Encoding.UTF8.GetString(b);
        }

        #endregion

        /// <summary>
        /// Convert To Decimal
        /// </summary>
        /// <param name="ba">bytearray from full file</param>
        /// <param name="i">Position i in file</param>
        /// <returns>integer representing decimal</returns>
        private static int ConvertToDecimal(byte[] ba, int i)
        {
            return (((int)ba[i]) * (256 ^ 3)) + (((int)ba[i + 1]) * (256 ^ 2)) + (((int)ba[i + 2]) * 256) + (((int)ba[i + 3]));
        }

        /// <summary>
        /// Read strings in array
        /// </summary>
        /// <param name="ba">bytearray</param>
        /// <param name="i">Position i in file</param>
        /// <param name="strLength">StringLength</param>
        /// <returns></returns>
        private static string StringReader(byte[] ba, int i, int strLength)
        {
            string value = "";

            for (int str = 0; str < strLength; str++)
            {
                value += B2S(ba[i + 1]);
                i += 2;
            }

            return value;
        }

        /// <summary>
        /// Reads through all the IOs (DDCI, DDCO, DCBM)
        /// </summary>
        /// <param name="bytearray">bytearray</param>
        /// <param name="i">Position i in file</param>
        /// <returns>IO object containing Channel and  IOState</returns>
        private static ReturnIO IOLoop(byte[] bytearray, int i, bool input)
        {
            i += 8;
            int strLength = ConvertToDecimal(bytearray, i);
            i += 4;
            string channel = StringReader(bytearray, i, strLength);
            i += strLength * 2;

            i += 20;

            /*if (ConvertToDecimal(bytearray, i-20) == 7) return new ReturnIO(i, new IO(channel, IOState.Input));
            else return new ReturnIO(i, new IO(channel, IOState.Output));*/

            if (input) return new ReturnIO(i, new IO(channel, IOState.Input, ConvertToDecimal(bytearray, i - 20)));
            else return new ReturnIO(i, new IO(channel, IOState.Output, ConvertToDecimal(bytearray, i - 20)));
        }

        /// <summary>
        /// Loops Through all Control-Entries
        /// </summary>
        /// <param name="ba">bytearray</param>
        /// <param name="i">Position i in file</param>
        /// <returns>ReturnControl-object containing the Control-object and updated position i</returns>
        private static ReturnControl GetControl(byte[] ba, int i)
        {
            TSIControl c;
            Modifier m1;
            Modifier m2;

            i += 8;
            int ID = ConvertToDecimal(ba, i);
            i += 4;
            int IO = ConvertToDecimal(ba, i);
            i += 4;
            int ActionID = ConvertToDecimal(ba, i);
            i += 12;

            int CMADunknown1 = ConvertToDecimal(ba, i);
            i += 4;

            int TypeOfController = ConvertToDecimal(ba, i);
            i += 4;
            int Interaction = ConvertToDecimal(ba, i);
            i += 4;
            int Deck = ConvertToDecimal(ba, i);
            i += 4;

            int CMADunknown2 = ConvertToDecimal(ba, i);
            i += 4;

            int Inverted = ConvertToDecimal(ba, i);
            i += 4;
            int SoftTakeover = ConvertToDecimal(ba, i);
            i += 4;
            int RotarySensitivity = ConvertToDecimal(ba, i);
            i += 4;
            int RotaryAcceleration = ConvertToDecimal(ba, i);
            i += 4;
            int ButtonOrElse = ConvertToDecimal(ba, i);
            i += 4;

            int CMADunknown3 = ConvertToDecimal(ba, i);
            i += 4;

            int InteractionValue = ConvertToDecimal(ba, i);
            i += 4;
            int strLength = ConvertToDecimal(ba, i);
            i += 4;
            string Comment = StringReader(ba, i, strLength);
            i += strLength * 2;

            int mod = ConvertToDecimal(ba, i);
            i += 4;
            int modParam = ConvertToDecimal(ba, i);
            i += 4;
            int modValue = ConvertToDecimal(ba, i);
            i += 4;
            m1 = new Modifier(mod, modParam, modValue);

            mod = ConvertToDecimal(ba, i);
            i += 4;
            modParam = ConvertToDecimal(ba, i);
            i += 4;
            modValue = ConvertToDecimal(ba, i);
            i += 4;
            m2 = new Modifier(mod, modParam, modValue);

            int CMADunknown4 = ConvertToDecimal(ba, i);
            i += 4;

            int ControllerRangeMin = ConvertToDecimal(ba, i);
            i += 4;

            int CMADunknown5 = ConvertToDecimal(ba, i);
            i += 4;

            int ControllerRangeMax = ConvertToDecimal(ba, i);
            i += 4;
            int MIDIRangeMin = ConvertToDecimal(ba, i);
            i += 4;
            int MIDIRangeMax = ConvertToDecimal(ba, i);
            i += 4;

            i += 4;
            int Blend = ConvertToDecimal(ba, i); // 95
            i += 16;

            IOState IOS;
            bool inv;
            bool soft;
            bool blend;

            if (IO == 1) IOS = IOState.Output;
            else IOS = IOState.Input;

            if (Inverted == 1) inv = true;
            else inv = false;

            if (SoftTakeover == 1) soft = true;
            else soft = false;

            if (Blend == 1) blend = true;
            else blend = false;

            c = new TSIControl(ID, IOS, ActionID, TypeOfController, Interaction, (DeckFocus)Deck, inv, soft, RotarySensitivity, RotaryAcceleration, ButtonOrElse, InteractionValue, Comment, m1, m2, ControllerRangeMin, ControllerRangeMax, MIDIRangeMin, MIDIRangeMax, blend);

            return new ReturnControl(i, c);
        }
    }
}
