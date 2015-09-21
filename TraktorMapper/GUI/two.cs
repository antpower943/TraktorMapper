using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TraktorMapper
{
    public partial class two : Form
    {
        public two()
        {
            InitializeComponent();
        }

        private void two_Resize(object sender, EventArgs e)
        {
            ucf.Location = new Point(0, 0);
            ucf.Size = this.ClientSize;
        }
    }
}
