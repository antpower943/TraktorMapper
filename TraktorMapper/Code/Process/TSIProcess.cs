using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TraktorMapper.Code.Objects;
using System.IO;
using System.Windows.Forms;
using TraktorMapper.Code.Process.TSI;

namespace TraktorMapper.Code.Process
{
    static class TSIProcess
    {
        public static List<TSIFile> Load()
        {
            OpenFileDialog l = new OpenFileDialog();

            l.Title = "Choose TSI-file";
            l.Filter = "Traktor 2 Settings | *.tsi";

            if (l.ShowDialog() == DialogResult.OK)
            {
                if (l.CheckFileExists)
                {
                    return TSILoad.GetTSI(l.FileName);
                }
                else
                {
                    MessageBox.Show("File Does not exist appearantly...");
                }
            }

            return null;
        }

        public static void Save(List<TSIFile> files)
        {
            if (files.Count != 0)
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Save TSI-file";
                s.Filter = "Traktor 2 Settings | *.tsi";

                if (s.ShowDialog() == DialogResult.OK)
                {
                    if (s.CheckFileExists)
                    {
                        if (MessageBox.Show("Are you sure you want to overwrite?", "Overwrite?", MessageBoxButtons.YesNo) == DialogResult.OK)
                        {
                            TSISave.Save(files, s.FileName);
                        }
                    }
                    else
                    {
                        TSISave.Save(files, s.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing has been loaded or created...");
            }
        }
    }
}
