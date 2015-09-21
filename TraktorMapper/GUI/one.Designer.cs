namespace TraktorMapper
{
    partial class one
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
            this.components = new System.ComponentModel.Container();
            this.list = new System.Windows.Forms.ListView();
            this.h_Control = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_IO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_Assignment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_Mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_MappedTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_Cond1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_Cond2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_load = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_add = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_sort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.ucs = new TraktorMapper.GUI.ucSelection();
            this.ucf = new TraktorMapper.GUI.ucFile();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AllowDrop = true;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.h_Control,
            this.h_IO,
            this.h_Assignment,
            this.h_Mode,
            this.h_MappedTo,
            this.h_Cond1,
            this.h_Cond2,
            this.h_Comment});
            this.list.ContextMenuStrip = this.cms;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(800, 500);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // h_Control
            // 
            this.h_Control.Text = "Control";
            this.h_Control.Width = 176;
            // 
            // h_IO
            // 
            this.h_IO.Text = "I/O";
            this.h_IO.Width = 50;
            // 
            // h_Assignment
            // 
            this.h_Assignment.Text = "Assignment";
            this.h_Assignment.Width = 87;
            // 
            // h_Mode
            // 
            this.h_Mode.Text = "Mode";
            this.h_Mode.Width = 68;
            // 
            // h_MappedTo
            // 
            this.h_MappedTo.Text = "Mapped To";
            this.h_MappedTo.Width = 126;
            // 
            // h_Cond1
            // 
            this.h_Cond1.Text = "Cond1";
            // 
            // h_Cond2
            // 
            this.h_Cond2.Text = "Cond2";
            // 
            // h_Comment
            // 
            this.h_Comment.Text = "Comment";
            this.h_Comment.Width = 183;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_load,
            this.cms_save,
            this.toolStripSeparator1,
            this.cms_add,
            this.cms_remove,
            this.cms_sort,
            this.toolStripSeparator2,
            this.cms_settings});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(118, 148);
            // 
            // cms_load
            // 
            this.cms_load.Name = "cms_load";
            this.cms_load.Size = new System.Drawing.Size(117, 22);
            this.cms_load.Text = "Load";
            this.cms_load.Click += new System.EventHandler(this.cms_load_Click);
            // 
            // cms_save
            // 
            this.cms_save.Name = "cms_save";
            this.cms_save.Size = new System.Drawing.Size(117, 22);
            this.cms_save.Text = "Save";
            this.cms_save.Click += new System.EventHandler(this.cms_save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // cms_add
            // 
            this.cms_add.Name = "cms_add";
            this.cms_add.Size = new System.Drawing.Size(117, 22);
            this.cms_add.Text = "Add";
            this.cms_add.Click += new System.EventHandler(this.cms_add_Click);
            // 
            // cms_remove
            // 
            this.cms_remove.Name = "cms_remove";
            this.cms_remove.Size = new System.Drawing.Size(117, 22);
            this.cms_remove.Text = "Remove";
            this.cms_remove.Click += new System.EventHandler(this.cms_remove_Click);
            // 
            // cms_sort
            // 
            this.cms_sort.Name = "cms_sort";
            this.cms_sort.Size = new System.Drawing.Size(117, 22);
            this.cms_sort.Text = "Sort";
            this.cms_sort.Click += new System.EventHandler(this.cms_sort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // cms_settings
            // 
            this.cms_settings.Name = "cms_settings";
            this.cms_settings.Size = new System.Drawing.Size(117, 22);
            this.cms_settings.Text = "Settings";
            // 
            // ucs
            // 
            this.ucs.BackColor = System.Drawing.Color.Gray;
            this.ucs.ContextMenuStrip = this.cms;
            this.ucs.Location = new System.Drawing.Point(0, 500);
            this.ucs.Name = "ucs";
            this.ucs.Size = new System.Drawing.Size(800, 500);
            this.ucs.TabIndex = 2;
            // 
            // ucf
            // 
            this.ucf.BackColor = System.Drawing.Color.CadetBlue;
            this.ucf.Comment = "";
            this.ucf.ContextMenuStrip = this.cms;
            this.ucf.Input = "";
            this.ucf.Location = new System.Drawing.Point(800, 0);
            this.ucf.Name = "ucf";
            this.ucf.Output = "";
            this.ucf.PageInfo = "";
            this.ucf.Size = new System.Drawing.Size(200, 1000);
            this.ucf.TabIndex = 1;
            this.ucf.Version = "";
            // 
            // one
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 742);
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.ucs);
            this.Controls.Add(this.ucf);
            this.Controls.Add(this.list);
            this.Name = "one";
            this.Text = "TraktorMapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.one_FormClosing);
            this.Resize += new System.EventHandler(this.one_Resize);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader h_Control;
        private System.Windows.Forms.ColumnHeader h_IO;
        private System.Windows.Forms.ColumnHeader h_Assignment;
        private System.Windows.Forms.ColumnHeader h_Mode;
        private System.Windows.Forms.ColumnHeader h_MappedTo;
        private System.Windows.Forms.ColumnHeader h_Cond1;
        private System.Windows.Forms.ColumnHeader h_Cond2;
        private System.Windows.Forms.ColumnHeader h_Comment;
        private GUI.ucFile ucf;
        private GUI.ucSelection ucs;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cms_load;
        private System.Windows.Forms.ToolStripMenuItem cms_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cms_add;
        private System.Windows.Forms.ToolStripMenuItem cms_remove;
        private System.Windows.Forms.ToolStripMenuItem cms_sort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cms_settings;
    }
}