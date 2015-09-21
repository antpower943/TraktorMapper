namespace TraktorMapper.GUI
{
    partial class ucFile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lpinfo = new System.Windows.Forms.Label();
            this.tbPageInfo = new System.Windows.Forms.TextBox();
            this.lpcomment = new System.Windows.Forms.Label();
            this.lpin = new System.Windows.Forms.Label();
            this.lpout = new System.Windows.Forms.Label();
            this.lpver = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDeck = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSubfile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lpinfo
            // 
            this.lpinfo.AutoSize = true;
            this.lpinfo.Location = new System.Drawing.Point(6, 12);
            this.lpinfo.Name = "lpinfo";
            this.lpinfo.Size = new System.Drawing.Size(59, 13);
            this.lpinfo.TabIndex = 0;
            this.lpinfo.Text = "Page Info: ";
            // 
            // tbPageInfo
            // 
            this.tbPageInfo.Enabled = false;
            this.tbPageInfo.Location = new System.Drawing.Point(66, 9);
            this.tbPageInfo.Name = "tbPageInfo";
            this.tbPageInfo.Size = new System.Drawing.Size(345, 20);
            this.tbPageInfo.TabIndex = 1;
            // 
            // lpcomment
            // 
            this.lpcomment.AutoSize = true;
            this.lpcomment.Location = new System.Drawing.Point(6, 38);
            this.lpcomment.Name = "lpcomment";
            this.lpcomment.Size = new System.Drawing.Size(57, 13);
            this.lpcomment.TabIndex = 2;
            this.lpcomment.Text = "Comment: ";
            // 
            // lpin
            // 
            this.lpin.AutoSize = true;
            this.lpin.Location = new System.Drawing.Point(6, 64);
            this.lpin.Name = "lpin";
            this.lpin.Size = new System.Drawing.Size(37, 13);
            this.lpin.TabIndex = 3;
            this.lpin.Text = "Input: ";
            // 
            // lpout
            // 
            this.lpout.AutoSize = true;
            this.lpout.Location = new System.Drawing.Point(6, 90);
            this.lpout.Name = "lpout";
            this.lpout.Size = new System.Drawing.Size(45, 13);
            this.lpout.TabIndex = 4;
            this.lpout.Text = "Output: ";
            // 
            // lpver
            // 
            this.lpver.AutoSize = true;
            this.lpver.Location = new System.Drawing.Point(6, 116);
            this.lpver.Name = "lpver";
            this.lpver.Size = new System.Drawing.Size(48, 13);
            this.lpver.TabIndex = 5;
            this.lpver.Text = "Version: ";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(66, 35);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(345, 20);
            this.tbComment.TabIndex = 6;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Location = new System.Drawing.Point(66, 61);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(345, 20);
            this.tbInput.TabIndex = 7;
            // 
            // tbOutput
            // 
            this.tbOutput.Enabled = false;
            this.tbOutput.Location = new System.Drawing.Point(66, 87);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(345, 20);
            this.tbOutput.TabIndex = 8;
            // 
            // tbVersion
            // 
            this.tbVersion.Enabled = false;
            this.tbVersion.Location = new System.Drawing.Point(66, 113);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(345, 20);
            this.tbVersion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deck:";
            // 
            // cbDeck
            // 
            this.cbDeck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeck.FormattingEnabled = true;
            this.cbDeck.Items.AddRange(new object[] {
            "Target Device",
            "Deck A",
            "Deck B",
            "Deck C",
            "Deck D"});
            this.cbDeck.Location = new System.Drawing.Point(66, 139);
            this.cbDeck.Name = "cbDeck";
            this.cbDeck.Size = new System.Drawing.Size(345, 21);
            this.cbDeck.TabIndex = 11;
            this.cbDeck.SelectedIndexChanged += new System.EventHandler(this.cbDeck_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(10, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 2);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // cbSubfile
            // 
            this.cbSubfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubfile.FormattingEnabled = true;
            this.cbSubfile.Location = new System.Drawing.Point(66, 175);
            this.cbSubfile.Name = "cbSubfile";
            this.cbSubfile.Size = new System.Drawing.Size(345, 21);
            this.cbSubfile.TabIndex = 14;
            this.cbSubfile.SelectedIndexChanged += new System.EventHandler(this.cbSubfile_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subfile:";
            // 
            // ucFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.cbSubfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDeck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.lpver);
            this.Controls.Add(this.lpout);
            this.Controls.Add(this.lpin);
            this.Controls.Add(this.lpcomment);
            this.Controls.Add(this.tbPageInfo);
            this.Controls.Add(this.lpinfo);
            this.Name = "ucFile";
            this.Size = new System.Drawing.Size(200, 500);
            this.Resize += new System.EventHandler(this.ucFile_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lpinfo;
        private System.Windows.Forms.TextBox tbPageInfo;
        private System.Windows.Forms.Label lpcomment;
        private System.Windows.Forms.Label lpin;
        private System.Windows.Forms.Label lpout;
        private System.Windows.Forms.Label lpver;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDeck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSubfile;
        private System.Windows.Forms.Label label3;
    }
}
