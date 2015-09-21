namespace TraktorMapper.GUI
{
    partial class ucSelection
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.cbAss = new System.Windows.Forms.ComboBox();
            this.cbIM = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbmod2 = new System.Windows.Forms.ComboBox();
            this.btnmod2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbmod1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmod1 = new System.Windows.Forms.Button();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.btnAddIn = new System.Windows.Forms.Button();
            this.btnAddOut = new System.Windows.Forms.Button();
            this.tbdata = new System.Windows.Forms.TextBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.tbComment);
            this.gb1.Controls.Add(this.btnReset);
            this.gb1.Controls.Add(this.btnNote);
            this.gb1.Controls.Add(this.btnLearn);
            this.gb1.Location = new System.Drawing.Point(3, 26);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(794, 75);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Device Mapping";
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comment";
            // 
            // tbComment
            // 
            this.tbComment.BackColor = System.Drawing.Color.Gray;
            this.tbComment.Location = new System.Drawing.Point(65, 45);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(446, 20);
            this.tbComment.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(410, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 20);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.Gray;
            this.btnNote.Enabled = false;
            this.btnNote.Location = new System.Drawing.Point(110, 20);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(300, 20);
            this.btnNote.TabIndex = 1;
            this.btnNote.Text = "-O-";
            this.btnNote.UseVisualStyleBackColor = false;
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.Gray;
            this.btnLearn.Enabled = false;
            this.btnLearn.Location = new System.Drawing.Point(10, 20);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(100, 20);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "--- LEARN ---";
            this.btnLearn.UseVisualStyleBackColor = false;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.cbAss);
            this.gb2.Controls.Add(this.cbIM);
            this.gb2.Controls.Add(this.cbType);
            this.gb2.Controls.Add(this.cbmod2);
            this.gb2.Controls.Add(this.btnmod2);
            this.gb2.Controls.Add(this.label9);
            this.gb2.Controls.Add(this.label10);
            this.gb2.Controls.Add(this.cbmod1);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.label7);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.btnmod1);
            this.gb2.Location = new System.Drawing.Point(3, 107);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(794, 131);
            this.gb2.TabIndex = 0;
            this.gb2.TabStop = false;
            this.gb2.Text = "Mapping Details";
            // 
            // cbAss
            // 
            this.cbAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAss.FormattingEnabled = true;
            this.cbAss.Location = new System.Drawing.Point(317, 102);
            this.cbAss.Name = "cbAss";
            this.cbAss.Size = new System.Drawing.Size(88, 21);
            this.cbAss.TabIndex = 16;
            // 
            // cbIM
            // 
            this.cbIM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIM.FormattingEnabled = true;
            this.cbIM.Location = new System.Drawing.Point(100, 100);
            this.cbIM.Name = "cbIM";
            this.cbIM.Size = new System.Drawing.Size(145, 21);
            this.cbIM.TabIndex = 15;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(100, 75);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(145, 21);
            this.cbType.TabIndex = 14;
            // 
            // cbmod2
            // 
            this.cbmod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmod2.FormattingEnabled = true;
            this.cbmod2.Location = new System.Drawing.Point(335, 37);
            this.cbmod2.Name = "cbmod2";
            this.cbmod2.Size = new System.Drawing.Size(70, 21);
            this.cbmod2.TabIndex = 13;
            // 
            // btnmod2
            // 
            this.btnmod2.BackColor = System.Drawing.Color.Gray;
            this.btnmod2.Location = new System.Drawing.Point(260, 36);
            this.btnmod2.Name = "btnmod2";
            this.btnmod2.Size = new System.Drawing.Size(75, 23);
            this.btnmod2.TabIndex = 12;
            this.btnmod2.Text = "-";
            this.btnmod2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(345, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Modifier";
            // 
            // cbmod1
            // 
            this.cbmod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmod1.FormattingEnabled = true;
            this.cbmod1.Location = new System.Drawing.Point(175, 37);
            this.cbmod1.Name = "cbmod1";
            this.cbmod1.Size = new System.Drawing.Size(70, 21);
            this.cbmod1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(100, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 2);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(185, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type of Controller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interaction Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modifier Conditions";
            // 
            // btnmod1
            // 
            this.btnmod1.BackColor = System.Drawing.Color.Gray;
            this.btnmod1.Location = new System.Drawing.Point(100, 36);
            this.btnmod1.Name = "btnmod1";
            this.btnmod1.Size = new System.Drawing.Size(75, 23);
            this.btnmod1.TabIndex = 1;
            this.btnmod1.Text = "-";
            this.btnmod1.UseVisualStyleBackColor = false;
            // 
            // gb3
            // 
            this.gb3.Location = new System.Drawing.Point(3, 244);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(794, 100);
            this.gb3.TabIndex = 17;
            this.gb3.TabStop = false;
            this.gb3.Text = "Button Options";
            // 
            // gb4
            // 
            this.gb4.Location = new System.Drawing.Point(3, 350);
            this.gb4.Name = "gb4";
            this.gb4.Size = new System.Drawing.Size(794, 100);
            this.gb4.TabIndex = 18;
            this.gb4.TabStop = false;
            this.gb4.Text = "Button Options";
            // 
            // btnAddIn
            // 
            this.btnAddIn.BackColor = System.Drawing.Color.Gray;
            this.btnAddIn.Location = new System.Drawing.Point(13, 3);
            this.btnAddIn.Name = "btnAddIn";
            this.btnAddIn.Size = new System.Drawing.Size(75, 23);
            this.btnAddIn.TabIndex = 19;
            this.btnAddIn.Text = "Add In...";
            this.btnAddIn.UseVisualStyleBackColor = false;
            // 
            // btnAddOut
            // 
            this.btnAddOut.BackColor = System.Drawing.Color.Gray;
            this.btnAddOut.Location = new System.Drawing.Point(87, 3);
            this.btnAddOut.Name = "btnAddOut";
            this.btnAddOut.Size = new System.Drawing.Size(75, 23);
            this.btnAddOut.TabIndex = 20;
            this.btnAddOut.Text = "Add Out...";
            this.btnAddOut.UseVisualStyleBackColor = false;
            // 
            // tbdata
            // 
            this.tbdata.Location = new System.Drawing.Point(8, 6);
            this.tbdata.Multiline = true;
            this.tbdata.Name = "tbdata";
            this.tbdata.Size = new System.Drawing.Size(783, 226);
            this.tbdata.TabIndex = 21;
            // 
            // ucSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.tbdata);
            this.Controls.Add(this.btnAddOut);
            this.Controls.Add(this.btnAddIn);
            this.Controls.Add(this.gb4);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "ucSelection";
            this.Size = new System.Drawing.Size(800, 500);
            this.Resize += new System.EventHandler(this.ucSelection_Resize);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Button btnmod1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmod1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbmod2;
        private System.Windows.Forms.Button btnmod2;
        private System.Windows.Forms.ComboBox cbAss;
        private System.Windows.Forms.ComboBox cbIM;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.Button btnAddIn;
        private System.Windows.Forms.Button btnAddOut;
        private System.Windows.Forms.TextBox tbdata;
    }
}
