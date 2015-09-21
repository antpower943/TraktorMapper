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
    public partial class three : Form
    {
        public three()
        {
            InitializeComponent();
        }

        private void three_Resize(object sender, EventArgs e)
        {
            ucs.Location = new Point(0, 0);
            ucs.Size = this.ClientSize;
        }
    }
}
