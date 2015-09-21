using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TraktorMapper.Code.Objects;
using TraktorMapper.Code.Process;

namespace TraktorMapper.GUI.wnd
{
    public partial class Pages : Form
    {
        List<TSIFile> Files = new List<TSIFile>();
        List<TSIFile> Files_Original = new List<TSIFile>();
        //List<int> SortL = new List<int>();
        private delegate void CallMe(List<TSIFile> files);
        bool userok = false;
        
        /// <summary>
        /// Window that gives possibility to Sort Remove or Add 'Pages' (subfiles) to the file
        /// </summary>
        /// <param name="files">the Files parmaeter</param>
        /// <param name="mode">0: Sort / 1: Add / 2: Remove</param>
        public Pages(List<TSIFile> files, int mode, int page)
        {
            PagesGo(files, mode, page);
        }

        private void PagesGo(List<TSIFile> files, int mode, int page)
        {
            InitializeComponent();
            Files = files;
            Files_Original = files;

            //int cnt = 0;

            foreach (TSIFile f in Files)
            {
                list.Items.Add(f.PFileComment + "     [" + f.PType + "]     (" + f.PConfigVersion + "/" + f.PBuildVersion + ")");
                //SortL.Add(cnt);
                //cnt++;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            List<TSIFile> Files0 = TSIProcess.Load();

            if (Files0 != null)
            {
                Files.AddRange(Files0);
            }

            RebuildList();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (Files.Count >= 2)
            {
                Files.RemoveAt(list.SelectedIndex);

                RebuildList();
            }
            else
            {
                Files.Clear();
                this.Close();
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            TSIFile temp = null;

            int sel = list.SelectedIndex;

            if (sel != 0)
            {
                temp = Files[sel];
                Files[sel] = Files[sel - 1];
                Files[sel - 1] = temp;

                RebuildList();

                list.SelectedIndex = sel - 1;
            }
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            TSIFile temp = null;

            int sel = list.SelectedIndex;

            if (sel != list.Items.Count - 1)
            {
                temp = Files[sel];
                Files[sel] = Files[sel + 1];
                Files[sel + 1] = temp;

                RebuildList();

                list.SelectedIndex = sel + 1;
            }
        }

        private void RebuildList()
        {
            int cursel = list.SelectedIndex;

            list.Items.Clear();

            foreach (TSIFile f in Files)
            {
                list.Items.Add(f.PFileComment + "     [" + f.PType + "]     (" + f.PConfigVersion + "/" + f.PBuildVersion + ")");
            }

            if (list.Items.Count > cursel) list.SelectedIndex = cursel;
            else list.SelectedIndex = list.Items.Count - 1;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
            userok = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            userok = false;
        }

        public List<TSIFile> GetFiles()
        {
            return Files;
        }

        public bool DialogResultOK()
        {
            return userok;
        }

        bool twicestop = false;

        private void Pages_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if (list.SelectedIndex != null) //&& (!twicestop))
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (list.SelectedIndex != 0) list.SelectedIndex -= 1;
                    else list.SelectedIndex = list.Items.Count - 1;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (list.SelectedIndex != list.Items.Count - 1) list.SelectedIndex += 1;
                    else list.SelectedIndex = 0;
                }
                else if (e.KeyCode == Keys.PageUp)
                {
                    btnup_Click(sender, e);
                    twicestop = true;
                }
                else if (e.KeyCode == Keys.PageDown)
                {
                    btndown_Click(sender, e);
                    twicestop = true;
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || e.KeyCode == Keys.OemMinus)
                {
                    Files.RemoveAt(list.SelectedIndex);

                    RebuildList();
                }
                else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Insert)
                {
                    List<TSIFile> Files0 = TSIProcess.Load();

                    if (Files0 != null)
                    {
                        Files.AddRange(Files0);
                    }

                    RebuildList();
                }

            }
            //else if (twicestop)
            //{
            //    twicestop = true;
            //}
        }
    }
}
