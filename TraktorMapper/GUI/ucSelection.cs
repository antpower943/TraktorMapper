using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TraktorMapper.GUI
{
    public partial class ucSelection : UserControl
    {
        //TraktorMapper.Main.Sub.TSIControl ctrl = null;

        public ucSelection()
        {
            InitializeComponent();

            Enable(false);
            tbComment.GotFocus += new EventHandler(tbComment_GotFocus);
            tbComment.LostFocus += new EventHandler(tbComment_LostFocus);
        }

        private void ucSelection_Resize(object sender, EventArgs e)
        {
            gb1.Size = new Size(this.Size.Width - 6, gb1.Size.Height);
            gb2.Size = new Size(this.Size.Width - 6, gb2.Size.Height);
            gb3.Size = new Size(this.Size.Width - 6, gb3.Size.Height);
            gb4.Size = new Size(this.Size.Width - 6, gb4.Size.Height);
        }

        private void tbComment_GotFocus(object sender, EventArgs e)
        {
            tbComment.BackColor = Color.DarkRed;
            tbComment.ForeColor = Color.White;
        }

        private void tbComment_LostFocus(object sender, EventArgs e)
        {
            tbComment.BackColor = gb1.BackColor;
            tbComment.ForeColor = Color.Black;
        }


        //     METHODS

        public void Enable(bool b)
        {
            gb1.Enabled = b;
            gb2.Enabled = b;
            gb3.Enabled = b;
            gb4.Enabled = b;
        }

        //public void SetOneSelected(TraktorMapper.Main.Sub.TSIControl tsictrl)
        //{
        //    ctrl = tsictrl;
        //}

        private void Update()
        {
            //btnNote.Text = ctrl.Note;
            //tbComment.Text = ctrl.Comment();
            //btnmod1.Text = ctrl.Modifier1().ID.ToString();
            ////cbmod1.Text = ctrl.Modifier1().Value;
            //btnmod2.Text = ctrl.Modifier2().ID.ToString();
            //cbmod2.Text = ctrl.Modifier2().Value;
            //cbType.Text = ctrl.ControllerType();
            //cbIM.Text = ctrl.Interaction();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        public void SetLogData(string data)
        {
            tbdata.Text = data;
        }
    }
}
