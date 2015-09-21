using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TraktorMapper.GUI.wnd
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            // Get values from the registry
            //GetRegistryKeys();

            // update components on the form
            PanelSize();
        }

        //private void GetRegistryKeys()
        //{
        //    tbax.Value = (int)r.OpenSubKey("Size", true).GetValue("LVX");
        //    tbay.Value = (int)r.OpenSubKey("Size", true).GetValue("LVY");
        //    tbbx.Value = (int)r.OpenSubKey("Size", true).GetValue("PselectX");
        //    tbby.Value = (int)r.OpenSubKey("Size", true).GetValue("PselectY");
        //    tbcx.Value = (int)r.OpenSubKey("Size", true).GetValue("PpageX");
        //    tbcy.Value = (int)r.OpenSubKey("Size", true).GetValue("PpageY");
        //    cbdebug.Checked = Convert.ToBoolean(r.OpenSubKey("Settings", true).GetValue("Debug"));
        //}

        //private void SetRegistryKeys()
        //{
        //    r.OpenSubKey("Size", true).SetValue("LVX", tbax.Value);
        //    r.OpenSubKey("Size", true).SetValue("LVY", tbay.Value);
        //    r.OpenSubKey("Size", true).SetValue("PselectX", tbbx.Value);
        //    r.OpenSubKey("Size", true).SetValue("PselectY", tbby.Value);
        //    r.OpenSubKey("Size", true).SetValue("PpageX", tbcx.Value);
        //    r.OpenSubKey("Size", true).SetValue("PpageY", tbcy.Value);
        //    r.OpenSubKey("Settings", true).SetValue("Debug", cbdebug.Checked);
        //}

        private void PanelSize()
        {
            p1.Size = new Size(tbax.Value * 3, tbay.Value * 3);
            p2.Size = new Size(tbbx.Value * 3, tbby.Value * 3);
            p3.Size = new Size(tbcx.Value * 3, tbcy.Value * 3);

            p1.Location = new Point(0, 0);
            p2.Location = new Point(0, tbay.Value * 3);
            p3.Location = new Point(tbax.Value * 3, 0);

            gba.Text = "A(" + tbax.Value + "," + tbay.Value + ")";
            gbb.Text = "B(" + tbbx.Value + "," + tbby.Value + ")";
            gbc.Text = "V(" + tbcx.Value + "," + tbcy.Value + ")";
        }

        private void PanelSizeEqualityCheck(object sender)
        {
            if (sender == tbax) { tbcx.Value = 100 - tbax.Value; tbbx.Value = tbax.Value; }
            else if (sender == tbbx) { tbax.Value = tbbx.Value; tbcx.Value = 100 - tbbx.Value; }
            else if (sender == tbcx) { tbax.Value = 100 - tbcx.Value; tbbx.Value = tbbx.Value; }

            else if (sender == tbay) tbby.Value = 100 - tbay.Value;
            else if (sender == tbby) tbay.Value = 100 - tbby.Value;
            else if (sender == tbcy) tbcy.Value = 100;
        }

        private void tbax_ValueChanged(object sender, EventArgs e)
        {
            PanelSizeEqualityCheck(sender);
            PanelSize();
        }

        private void btnsizereset_Click(object sender, EventArgs e)
        {
            tbax.Value = 80;
            tbay.Value = 50;

            tbbx.Value = 80;
            tbby.Value = 50;

            tbcx.Value = 20;
            tbcy.Value = 100;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //SetRegistryKeys();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
