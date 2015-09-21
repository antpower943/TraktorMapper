using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TraktorMapper.Code.Events;
using TraktorMapper.Code.Enum;

namespace TraktorMapper.GUI
{
    public partial class ucFile : UserControl
    {
        public ucFile()
        {
            InitializeComponent();
        }

        private void ucFile_Resize(object sender, EventArgs e)
        {
            tbPageInfo.Size = new Size(this.Size.Width - 70, tbPageInfo.Height);
            tbComment.Size = new Size(this.Size.Width - 70, tbComment.Height);
            tbInput.Size = new Size(this.Size.Width - 70, tbInput.Height);
            tbOutput.Size = new Size(this.Size.Width - 70, tbOutput.Height);
            tbVersion.Size = new Size(this.Size.Width - 70, tbVersion.Height);
            cbDeck.Size = new Size(this.Size.Width - 70, cbDeck.Height);
            cbSubfile.Size = new Size(this.Size.Width - 70, cbSubfile.Height);
        }

        #region Get/Set

        public string PageInfo
        {
            get { return tbPageInfo.Text; }
            set { tbPageInfo.Text = value; }
        }

        public string Comment
        {
            get { return tbComment.Text; }
            set { tbComment.Text = value; }
        }

        public string Input
        {
            get { return tbInput.Text; }
            set { tbInput.Text = value; }
        }

        public string Output
        {
            get { return tbOutput.Text; }
            set { tbOutput.Text = value; }
        }

        public string Version
        {
            get { return tbVersion.Text; }
            set { tbVersion.Text = value; }
        }

        public void ClearSubfile()
        {
            this.cbSubfile.Items.Clear();
        }

        public void AddSubfile(string subfile)
        {
            this.cbSubfile.Items.Add(subfile);
        }

        public void SelectSubfile(int number)
        {
            this.cbSubfile.SelectedIndex = number;
        }

        public void SelectDeck(int deck)
        {
            this.cbDeck.SelectedIndex = deck;
        }

        public int SelectedSubfile()
        {
            return cbSubfile.SelectedIndex;
        }

        public int SelectedDeck()
        {
            return cbDeck.SelectedIndex;
        }

        #endregion

        #region Methods

        public void Clear()
        {
            tbPageInfo.Text = "";
            tbComment.Text = "";
            tbInput.Text = "";
            tbOutput.Text = "";
            tbVersion.Text = "";
            cbDeck.SelectedIndex = 0;
            cbSubfile.Items.Clear();
        }

        private ucfEventArgs GetEventHandler()
        {
            ucfEventArgs ev = new ucfEventArgs();
            ev.Page = cbSubfile.SelectedIndex;
            ev.Comment = tbComment.Text;

            if (cbDeck.SelectedIndex != 4) ev.Deck = (DeckFocus)cbDeck.SelectedIndex;
            else ev.Deck = DeckFocus.Target;

            return ev;
        }

        #endregion

        #region EVENTS

        // Other Page Selected

        public event EventHandler OnPageChanged;
        protected virtual void PageChanged (ucfEventArgs e)
        {
            EventHandler eh = OnPageChanged;
            if (eh != null) eh(this, e);
        }

        private void cbSubfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageChanged(GetEventHandler());
        }   

        // DeckChanged & CommentChanged

        public event EventHandler OnDeckChanged;
        public event EventHandler OnCommentChanged;

        protected virtual void DeckChanged(ucfEventArgs e)
        {
            EventHandler eh = OnDeckChanged;
            if (eh != null) eh(this, e);
        }

        protected virtual void CommentChanged(ucfEventArgs e)
        {
            EventHandler eh = OnCommentChanged;
            if (eh != null) eh(this, e);
        }

        private void cbDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeckChanged(GetEventHandler());
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {
            CommentChanged(GetEventHandler());
        }

        #endregion
    }
}
