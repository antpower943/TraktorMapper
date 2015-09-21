namespace TraktorMapper.GUI.wnd
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnsizereset = new System.Windows.Forms.Button();
            this.gbc = new System.Windows.Forms.GroupBox();
            this.tbcy = new System.Windows.Forms.TrackBar();
            this.tbcx = new System.Windows.Forms.TrackBar();
            this.gbb = new System.Windows.Forms.GroupBox();
            this.tbby = new System.Windows.Forms.TrackBar();
            this.tbbx = new System.Windows.Forms.TrackBar();
            this.gba = new System.Windows.Forms.GroupBox();
            this.tbay = new System.Windows.Forms.TrackBar();
            this.tbax = new System.Windows.Forms.TrackBar();
            this.pcontainer = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cbdebug = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcx)).BeginInit();
            this.gbb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbx)).BeginInit();
            this.gba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbax)).BeginInit();
            this.pcontainer.SuspendLayout();
            this.p3.SuspendLayout();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One Window";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(99, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Three Windows";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnsizereset);
            this.tabPage1.Controls.Add(this.gbc);
            this.tabPage1.Controls.Add(this.gbb);
            this.tabPage1.Controls.Add(this.gba);
            this.tabPage1.Controls.Add(this.pcontainer);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Window";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnsizereset
            // 
            this.btnsizereset.Location = new System.Drawing.Point(425, 17);
            this.btnsizereset.Name = "btnsizereset";
            this.btnsizereset.Size = new System.Drawing.Size(75, 23);
            this.btnsizereset.TabIndex = 7;
            this.btnsizereset.Text = "Reset";
            this.btnsizereset.UseVisualStyleBackColor = true;
            this.btnsizereset.Click += new System.EventHandler(this.btnsizereset_Click);
            // 
            // gbc
            // 
            this.gbc.Controls.Add(this.tbcy);
            this.gbc.Controls.Add(this.tbcx);
            this.gbc.Location = new System.Drawing.Point(316, 253);
            this.gbc.Name = "gbc";
            this.gbc.Size = new System.Drawing.Size(190, 91);
            this.gbc.TabIndex = 6;
            this.gbc.TabStop = false;
            this.gbc.Text = "C(x,x)";
            // 
            // tbcy
            // 
            this.tbcy.BackColor = System.Drawing.Color.White;
            this.tbcy.Location = new System.Drawing.Point(6, 54);
            this.tbcy.Maximum = 100;
            this.tbcy.Name = "tbcy";
            this.tbcy.Size = new System.Drawing.Size(178, 45);
            this.tbcy.TabIndex = 4;
            this.tbcy.TickFrequency = 10;
            this.tbcy.ValueChanged += new System.EventHandler(this.tbax_ValueChanged);
            // 
            // tbcx
            // 
            this.tbcx.BackColor = System.Drawing.Color.White;
            this.tbcx.Location = new System.Drawing.Point(6, 19);
            this.tbcx.Maximum = 100;
            this.tbcx.Name = "tbcx";
            this.tbcx.Size = new System.Drawing.Size(178, 45);
            this.tbcx.TabIndex = 3;
            this.tbcx.TickFrequency = 10;
            this.tbcx.ValueChanged += new System.EventHandler(this.tbax_ValueChanged);
            // 
            // gbb
            // 
            this.gbb.Controls.Add(this.tbby);
            this.gbb.Controls.Add(this.tbbx);
            this.gbb.Location = new System.Drawing.Point(316, 148);
            this.gbb.Name = "gbb";
            this.gbb.Size = new System.Drawing.Size(190, 91);
            this.gbb.TabIndex = 5;
            this.gbb.TabStop = false;
            this.gbb.Text = "B(x,x)";
            // 
            // tbby
            // 
            this.tbby.BackColor = System.Drawing.Color.White;
            this.tbby.Location = new System.Drawing.Point(6, 54);
            this.tbby.Maximum = 100;
            this.tbby.Name = "tbby";
            this.tbby.Size = new System.Drawing.Size(178, 45);
            this.tbby.TabIndex = 4;
            this.tbby.TickFrequency = 10;
            this.tbby.ValueChanged += new System.EventHandler(this.tbax_ValueChanged);
            // 
            // tbbx
            // 
            this.tbbx.BackColor = System.Drawing.Color.White;
            this.tbbx.Location = new System.Drawing.Point(6, 19);
            this.tbbx.Maximum = 100;
            this.tbbx.Name = "tbbx";
            this.tbbx.Size = new System.Drawing.Size(178, 45);
            this.tbbx.TabIndex = 3;
            this.tbbx.TickFrequency = 10;
            this.tbbx.ValueChanged += new System.EventHandler(this.tbax_ValueChanged);
            // 
            // gba
            // 
            this.gba.Controls.Add(this.tbay);
            this.gba.Controls.Add(this.tbax);
            this.gba.Location = new System.Drawing.Point(316, 43);
            this.gba.Name = "gba";
            this.gba.Size = new System.Drawing.Size(190, 91);
            this.gba.TabIndex = 2;
            this.gba.TabStop = false;
            this.gba.Text = "A(x,x)";
            // 
            // tbay
            // 
            this.tbay.BackColor = System.Drawing.Color.White;
            this.tbay.Location = new System.Drawing.Point(6, 54);
            this.tbay.Maximum = 100;
            this.tbay.Name = "tbay";
            this.tbay.Size = new System.Drawing.Size(178, 45);
            this.tbay.TabIndex = 4;
            this.tbay.TickFrequency = 10;
            this.tbay.ValueChanged += new System.EventHandler(this.tbax_ValueChanged);
            // 
            // tbax
            // 
            this.tbax.BackColor = System.Drawing.Color.White;
            this.tbax.Location = new System.Drawing.Point(6, 19);
            this.tbax.Maximum = 100;
            this.tbax.Name = "tbax";
            this.tbax.Size = new System.Drawing.Size(178, 45);
            this.tbax.TabIndex = 3;
            this.tbax.TickFrequency = 10;
            this.tbax.ValueChanged += new System.EventHandler(this.tbax_ValueChanged);
            // 
            // pcontainer
            // 
            this.pcontainer.Controls.Add(this.p3);
            this.pcontainer.Controls.Add(this.p1);
            this.pcontainer.Controls.Add(this.p2);
            this.pcontainer.Location = new System.Drawing.Point(6, 40);
            this.pcontainer.Name = "pcontainer";
            this.pcontainer.Size = new System.Drawing.Size(300, 300);
            this.pcontainer.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p3.BackColor = System.Drawing.Color.CadetBlue;
            this.p3.Controls.Add(this.label3);
            this.p3.Location = new System.Drawing.Point(240, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(60, 300);
            this.p3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "C";
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.BackColor = System.Drawing.Color.Firebrick;
            this.p1.Controls.Add(this.label1);
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(240, 150);
            this.p1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.BackColor = System.Drawing.Color.Gray;
            this.p2.Controls.Add(this.label2);
            this.p2.Location = new System.Drawing.Point(0, 150);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(240, 150);
            this.p2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbdebug);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TSI";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(457, 461);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(376, 461);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cbdebug
            // 
            this.cbdebug.AutoSize = true;
            this.cbdebug.Location = new System.Drawing.Point(20, 20);
            this.cbdebug.Name = "cbdebug";
            this.cbdebug.Size = new System.Drawing.Size(88, 17);
            this.cbdebug.TabIndex = 0;
            this.cbdebug.Text = "Debug Mode";
            this.cbdebug.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(544, 490);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Settings";
            this.Text = "TraktorMapper Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbc.ResumeLayout(false);
            this.gbc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcx)).EndInit();
            this.gbb.ResumeLayout(false);
            this.gbb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbx)).EndInit();
            this.gba.ResumeLayout(false);
            this.gba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbax)).EndInit();
            this.pcontainer.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel pcontainer;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gba;
        private System.Windows.Forms.TrackBar tbax;
        private System.Windows.Forms.TrackBar tbay;
        private System.Windows.Forms.GroupBox gbc;
        private System.Windows.Forms.TrackBar tbcy;
        private System.Windows.Forms.TrackBar tbcx;
        private System.Windows.Forms.GroupBox gbb;
        private System.Windows.Forms.TrackBar tbby;
        private System.Windows.Forms.TrackBar tbbx;
        private System.Windows.Forms.Button btnsizereset;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.CheckBox cbdebug;
    }
}