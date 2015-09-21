namespace TraktorMapper
{
    partial class three
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
            this.ucs = new TraktorMapper.GUI.ucSelection();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_load = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_add = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_sort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucs
            // 
            this.ucs.BackColor = System.Drawing.Color.Gray;
            this.ucs.ContextMenuStrip = this.cms;
            this.ucs.Location = new System.Drawing.Point(0, 0);
            this.ucs.Name = "ucs";
            this.ucs.Size = new System.Drawing.Size(800, 471);
            this.ucs.TabIndex = 0;
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
            // 
            // cms_save
            // 
            this.cms_save.Name = "cms_save";
            this.cms_save.Size = new System.Drawing.Size(117, 22);
            this.cms_save.Text = "Save";
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
            // 
            // cms_remove
            // 
            this.cms_remove.Name = "cms_remove";
            this.cms_remove.Size = new System.Drawing.Size(117, 22);
            this.cms_remove.Text = "Remove";
            // 
            // cms_sort
            // 
            this.cms_sort.Name = "cms_sort";
            this.cms_sort.Size = new System.Drawing.Size(117, 22);
            this.cms_sort.Text = "Sort";
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
            // three
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.ucs);
            this.Name = "three";
            this.Text = "three - ucs";
            this.Resize += new System.EventHandler(this.three_Resize);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ContextMenuStrip cms;
        public System.Windows.Forms.ToolStripMenuItem cms_load;
        public System.Windows.Forms.ToolStripMenuItem cms_save;
        public System.Windows.Forms.ToolStripMenuItem cms_add;
        public System.Windows.Forms.ToolStripMenuItem cms_remove;
        public System.Windows.Forms.ToolStripMenuItem cms_sort;
        public System.Windows.Forms.ToolStripMenuItem cms_settings;
        public GUI.ucSelection ucs;
    }
}