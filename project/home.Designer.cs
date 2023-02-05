namespace project
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            this.fpn = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaNhữngÔĐãChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpn
            // 
            this.fpn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpn.AutoScroll = true;
            this.fpn.BackColor = System.Drawing.SystemColors.Control;
            this.fpn.Location = new System.Drawing.Point(0, 0);
            this.fpn.Name = "fpn";
            this.fpn.Size = new System.Drawing.Size(1539, 518);
            this.fpn.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaNhữngÔĐãChọnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 40);
            // 
            // xóaNhữngÔĐãChọnToolStripMenuItem
            // 
            this.xóaNhữngÔĐãChọnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaNhữngÔĐãChọnToolStripMenuItem.Name = "xóaNhữngÔĐãChọnToolStripMenuItem";
            this.xóaNhữngÔĐãChọnToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.xóaNhữngÔĐãChọnToolStripMenuItem.Text = "Xóa";
            this.xóaNhữngÔĐãChọnToolStripMenuItem.Click += new System.EventHandler(this.xóaNhữngÔĐãChọnToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.fpn);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1773, 570);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaNhữngÔĐãChọnToolStripMenuItem;
    }
}
