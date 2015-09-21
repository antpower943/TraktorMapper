using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TraktorMapper.Code.Process;
using TraktorMapper.Code.Objects;
using TraktorMapper.Code.Enum;
using TraktorMapper.Code.Events;
using TraktorMapper.GUI.wnd;

namespace TraktorMapper
{
    public partial class one : Form
    {
        Code.Objects.SaveFile sf = new Code.Objects.SaveFile();
        two two = new two();
        three three = new three();
        List<TSIFile> files = new List<TSIFile>();
        int currentpage = 0;

        public one()
        {
            InitializeComponent();

            // Load settings file

            if (File.Exists(Directory.GetCurrentDirectory() + @"\settings.set"))
            {
                sf = Code.Serializer.DeSerializeObject(Directory.GetCurrentDirectory() + @"\settings.set");
            }

            ProcessSettings();
        }

        /// <summary>
        /// Runs trough all the settings and adjusts them where needed
        /// </summary>
        private void ProcessSettings()
        {
            // First up, is the window size.
            // We'll check if we use one or more windows
            // Since the resize is also needed for window resizing, it is placed in anothe method

            if (!sf.OneWindow)
            {
                // Show correct windows
                ucf.Visible = false;
                ucs.Visible = false;

                two.Show();
                three.Show();

                // Sign on event handlers for anything on the other forms
                two.cms_load.Click += new EventHandler(cms_load_Click);
                three.cms_load.Click += new EventHandler(cms_load_Click);
                two.cms_save.Click += new EventHandler(cms_save_Click);
                three.cms_save.Click += new EventHandler(cms_save_Click);

                two.FormClosing += new FormClosingEventHandler(one_FormClosing);
                three.FormClosing += new FormClosingEventHandler(one_FormClosing);

                //two.ucf.On += new Code.Events.Events.CEventHandler(ucf_OnNewPage);
                // OnChangePage Event
                two.ucf.OnPageChanged += new EventHandler(ucf_OnPageChanged);
                two.ucf.OnDeckChanged += new EventHandler(ucf_OnDeckChanged);
                two.ucf.OnCommentChanged += new EventHandler(ucf_OnCommentChanged);
            }
            else
            {
                //ucf.OnNewPage += new Code.Events.Events.CEventHandler(ucf_OnNewPage);
                // OnChangePage Event
                ucf.OnPageChanged += new EventHandler(ucf_OnPageChanged);
                ucf.OnDeckChanged += new EventHandler(ucf_OnDeckChanged);
                ucf.OnCommentChanged += new EventHandler(ucf_OnCommentChanged);
            }

            ResizeLayout();

        }

        private void ResizeLayout()
        {
            if (sf.OneWindow) // Just one window...
            {
                // Now size the objects
                list.Location = new Point(0, 0);
                list.Size = new Size((this.ClientSize.Width * sf.SizeListX) / 100, (this.ClientSize.Height * sf.SizeListY) / 100);

                ucs.Location = new Point(0, list.Size.Height + 2);
                ucs.Size = new Size((this.ClientSize.Width * sf.SizeUcsX) / 100, (this.ClientSize.Height * sf.SizeUcsY) / 100 - 2 + 1);

                ucf.Location = new Point(list.Size.Width + 2, 0);
                ucf.Size = new Size((this.ClientSize.Width * sf.SizeUcfX) / 100 - 2 + 1, (this.ClientSize.Height * sf.SizeUcfY) / 100);

            }
            else // 3 windows
            {
                list.Location = new Point(0, 0);
                list.Size = this.ClientSize;
            }
        }

        private void UpdateAll(int page)
        {
            currentpage = page;
            FillList();
            FillFile(true);
        }

        private void UpdateFileInfo()
        {
            FillFile(true);
        }

        private void UpdatePage(int page)
        {
            currentpage = page;
            FillList();
            FillFile();
        }

        private void ClearAll()
        {
            list.Items.Clear();
            two.ucf.Clear();
            ucf.Clear();
        }

        #region Filling with data

        private void FillList()
        {
            TSIFile f = files[currentpage];

            list.Items.Clear();

            for (int i = 0; i < f.Controls.Count; i++)
            {
                string sio = "";
                string deck = "";
                string mod1 = "";
                string mod2 = "";

                if (f.Controls[i].IO() == IOState.Input) sio = "Input";
                else if (f.Controls[i].IO() == IOState.Output) sio = "Output";

                if ((f.Controls[i].ActionID() >= 2548) && (f.Controls[i].ActionID() <= 2555)) deck = "Global";
                else
                {
                    if (f.Controls[i].Deck() == DeckFocus.DeckA) deck = "Deck A";
                    else if (f.Controls[i].Deck() == DeckFocus.DeckB) deck = "Deck B";
                    else if (f.Controls[i].Deck() == DeckFocus.DeckC) deck = "Deck C";
                    else if (f.Controls[i].Deck() == DeckFocus.DeckD) deck = "Deck D";
                    else if (f.Controls[i].Deck() == DeckFocus.Target) deck = "Global";
                }

                if (deck == "")
                {
                    Console.WriteLine("DECK");
                    Console.WriteLine(f.Controls[i].ID());
                    Console.WriteLine(i);
                }

                if (f.Controls[i].Modifier1().ID != 0)
                {
                    //mod1 = d.GetModName(f.Controls[i].Modifier1().ID) + " | " + f.Controls[i].Modifier1().Parameter + " = " + f.Controls[i].Modifier1().Value;
                    mod1 = "ID" + f.Controls[i].Modifier1().ID + " | " + f.Controls[i].Modifier1().Parameter + " = " + f.Controls[i].Modifier1().Value;
                }

                if (f.Controls[i].Modifier2().ID != 0)
                {
                    //mod2 = d.GetModName(f.Controls[i].Modifier2().ID) + " | " + f.Controls[i].Modifier2().Parameter + " = " + f.Controls[i].Modifier2().Value;
                    mod2 = "ID" + f.Controls[i].Modifier2().ID + " | " + f.Controls[i].Modifier2().Parameter + " = " + f.Controls[i].Modifier2().Value;
                }

                //string ctrl = d.GetName(f.Controls[i].ActionID());
                string ctrl = "ID" + f.Controls[i].ActionID();

                if (ctrl == null) ctrl = "ID" + f.Controls[i].ActionID();

                string mode = "";

                if (f.Controls[i].ControllerType() == 0)
                {
                    switch (f.Controls[i].Interaction())
                    {
                        case 0:
                            mode = "Trigger";
                            break;
                        case 1:
                            mode = "Toggle";
                            break;
                        case 2:
                            mode = "Hold";
                            break;
                        case 3:
                            mode = "Direct";
                            break;
                        case 4:
                            mode = "Relative";
                            break;
                        case 5:
                            mode = "Inc";
                            break;
                        case 6:
                            mode = "Dec";
                            break;
                        case 7:
                            mode = "Reset";
                            break;
                        default:
                            mode = f.Controls[i].Interaction().ToString();
                            break;
                    }
                }
                else mode = "Output";
                ListViewItem lvi = null;

                bool debug = false;

                if (!debug) { lvi = new ListViewItem(new string[] { ctrl, sio, deck, mode, f.Controls[i].Note, mod1, mod2, f.Controls[i].Comment() }, -1); }
                else { lvi = new ListViewItem(new string[] { "ID" + f.Controls[i].ActionID().ToString(), f.Controls[i].IO().ToString(), f.Controls[i].Deck().ToString(), f.Controls[i].Interaction().ToString(), f.Controls[i].Note, f.Controls[i].Modifier1().ID + "| " + f.Controls[i].Modifier1().Parameter + " = " + f.Controls[i].Modifier1().Value, f.Controls[i].Modifier2().ID + "| " + f.Controls[i].Modifier2().Parameter + " = " + f.Controls[i].Modifier2().Value, f.Controls[i].Comment() }, -1); }

                list.Items.Add(lvi);
            }
        }

        private void FillFile()
        {
            FillFile(false);
        }

        private void FillFile(bool reloadsubfiles)
        {
            if (sf.OneWindow)
            {
                ucf.PageInfo = files[currentpage].PType;
                ucf.Comment = files[currentpage].PFileComment;
                ucf.Input = files[currentpage].PInput;
                ucf.Output = files[currentpage].POutput;
                ucf.Version = files[currentpage].PConfigVersion + " (build " + files[currentpage].PBuildVersion + ")";
                ucf.SelectDeck(files[currentpage].PDeviceTarget);

                if (reloadsubfiles)
                {
                    ucf.ClearSubfile();
                    int cnt = 0;

                    foreach (TSIFile f in files)
                    {
                        string identifier = "";

                        if (f.PFileComment != "") identifier = f.PFileComment;
                        else identifier = f.PType;

                        ucf.AddSubfile("[" + cnt + "] " + identifier);
                        cnt++;
                    }

                    ucf.SelectSubfile(currentpage);
                }
            }
            else
            {
                two.ucf.PageInfo = files[currentpage].PType;
                two.ucf.Comment = files[currentpage].PFileComment;
                two.ucf.Input = files[currentpage].PInput;
                two.ucf.Output = files[currentpage].POutput;
                two.ucf.Version = files[currentpage].PConfigVersion + " (build " + files[currentpage].PBuildVersion + ")";
                two.ucf.SelectDeck(files[currentpage].PDeviceTarget);

                if (reloadsubfiles)
                {
                    two.ucf.ClearSubfile();
                    int cnt = 0;

                    foreach (TSIFile f in files)
                    {
                        string identifier = "";

                        if (f.PFileComment != "") identifier = f.PFileComment;
                        else identifier = f.PType;

                        two.ucf.AddSubfile("[" + cnt + "] " + identifier);
                        cnt++;
                    }

                    two.ucf.SelectSubfile(currentpage);
                }
            }

            
        }

        private void FillSelection(int selected)
        {

        }

        private void FillSingleSelection(int selection)
        {
            if (sf.OneWindow)
            {

            }
            else
            {

            }
        }

        #endregion

        #region cms

        private void cms_load_Click(object sender, EventArgs e)
        {
            files = TSIProcess.Load();

            if (files != null)
            {
                currentpage = 0;
                FillList();
                FillFile(true);
            }
        }

        private void cms_save_Click(object sender, EventArgs e)
        {
            TSIProcess.Save(files);
        }

        private void cms_add_Click(object sender, EventArgs e)
        {
            if (files.Count != 0)
            {
                Pages p = new Pages(files, 0, currentpage);
                p.ShowDialog();
                files = p.GetFiles();
                UpdateAll(0);
            }
            else
            {
                cms_load_Click(sender, e);
            }
        }

        private void cms_remove_Click(object sender, EventArgs e)
        {
            if (files.Count != 0)
            {
                Pages p = new Pages(files, 1, currentpage);
                p.ShowDialog();
                files = p.GetFiles();

                if (files.Count != 0) UpdateAll(0);
                else ClearAll();
            }
            else
            {
                MessageBox.Show("Can't remove what isn't there");
            }
        }

        private void cms_sort_Click(object sender, EventArgs e)
        {
            if (files.Count != 0)
            {
                Pages p = new Pages(files, 2, currentpage);
                p.ShowDialog();
                files = p.GetFiles();

                if (files.Count != 0) UpdateAll(0);
                else ClearAll();
            }
            else
            {
                MessageBox.Show("We do not have the ability to sort the unsortable...");
            }
        }

        #endregion

        #region one

        private void one_Resize(object sender, EventArgs e)
        {
            ResizeLayout();
        }

        private void one_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ucf

        private void ucf_OnPageChanged(object sender, EventArgs e)
        {
            if (files.Count != 0)
            {
                if (currentpage != ((ucfEventArgs)e).Page) UpdatePage(((ucfEventArgs)e).Page);
            }
        }

        private void ucf_OnDeckChanged(object sender, EventArgs e)
        {
            if (files.Count != 0)
            {
                files[currentpage].PDeviceTarget = (int)((ucfEventArgs)e).Deck;
            }
        }

        private void ucf_OnCommentChanged(object sender, EventArgs e)
        {
            if (files.Count != 0)
            {
                files[currentpage].PFileComment = ((ucfEventArgs)e).Comment;
                UpdateFileInfo();
            }
        }

        #endregion

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedIndices.Count == 1)
            {
                //ucs.SetLogData(files[list.SelectedIndices[0]].
            }
        }
    }
}
