namespace TraktorMapper.GUI.wnd
{
    partial class Pages
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
            this.list = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(557, 407);
            this.list.TabIndex = 0;
            this.list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Lime;
            this.btnadd.Location = new System.Drawing.Point(575, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnremove.Location = new System.Drawing.Point(575, 41);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            this.btnremove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.Aqua;
            this.btnup.Location = new System.Drawing.Point(575, 70);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 3;
            this.btnup.Text = "Move Up";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            this.btnup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnok.Location = new System.Drawing.Point(575, 396);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            this.btnok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(575, 367);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // btndown
            // 
            this.btndown.BackColor = System.Drawing.Color.Aqua;
            this.btndown.Location = new System.Drawing.Point(575, 99);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 23);
            this.btndown.TabIndex = 6;
            this.btndown.Text = "Move Down";
            this.btndown.UseVisualStyleBackColor = false;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            this.btndown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 208);
            this.label1.TabIndex = 7;
            this.label1.Text = "Up/Down\r\n> Navigate\r\n\r\nPageUp/\r\nPageDown\r\n> Move\r\n\r\nDelete/-/\r\nBackspace\r\n> Remov" +
    "e\r\n\r\nInsert/+\r\n> Add\r\n\r\nEnter\r\n> OK";
            // 
            // Pages
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Pages";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Subfiles";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pages_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Label label1;
    }
}