namespace project
{
    partial class client
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
            this.txtmess = new System.Windows.Forms.TextBox();
            this.lsvmess = new System.Windows.Forms.ListView();
            this.btnsent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmess
            // 
            this.txtmess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmess.Location = new System.Drawing.Point(12, 368);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(400, 28);
            this.txtmess.TabIndex = 0;
            this.txtmess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmess_KeyDown);
            // 
            // lsvmess
            // 
            this.lsvmess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvmess.HideSelection = false;
            this.lsvmess.Location = new System.Drawing.Point(12, 12);
            this.lsvmess.Name = "lsvmess";
            this.lsvmess.Size = new System.Drawing.Size(501, 331);
            this.lsvmess.TabIndex = 1;
            this.lsvmess.UseCompatibleStateImageBehavior = false;
            this.lsvmess.View = System.Windows.Forms.View.List;
            // 
            // btnsent
            // 
            this.btnsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsent.Location = new System.Drawing.Point(435, 365);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(78, 32);
            this.btnsent.TabIndex = 2;
            this.btnsent.Text = "Gửi";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 418);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.lsvmess);
            this.Controls.Add(this.txtmess);
            this.MaximizeBox = false;
            this.Name = "client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmess;
        private System.Windows.Forms.ListView lsvmess;
        private System.Windows.Forms.Button btnsent;
    }
}