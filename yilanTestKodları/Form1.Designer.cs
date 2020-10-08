namespace yilanTestKodları
{
    partial class Form1
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
            this.saha = new System.Windows.Forms.Panel();
            this.lblDurdu = new System.Windows.Forms.Label();
            this.lblOyunBitti = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.saha.SuspendLayout();
            this.SuspendLayout();
            // 
            // saha
            // 
            this.saha.Controls.Add(this.lblAciklama);
            this.saha.Controls.Add(this.lblOyunBitti);
            this.saha.Controls.Add(this.lblDurdu);
            this.saha.Location = new System.Drawing.Point(12, 12);
            this.saha.Name = "saha";
            this.saha.Size = new System.Drawing.Size(400, 400);
            this.saha.TabIndex = 0;
            // 
            // lblDurdu
            // 
            this.lblDurdu.AutoSize = true;
            this.lblDurdu.Location = new System.Drawing.Point(319, 124);
            this.lblDurdu.Name = "lblDurdu";
            this.lblDurdu.Size = new System.Drawing.Size(35, 13);
            this.lblDurdu.TabIndex = 0;
            this.lblDurdu.Text = "label1";
            // 
            // lblOyunBitti
            // 
            this.lblOyunBitti.AutoSize = true;
            this.lblOyunBitti.Location = new System.Drawing.Point(168, 158);
            this.lblOyunBitti.Name = "lblOyunBitti";
            this.lblOyunBitti.Size = new System.Drawing.Size(35, 13);
            this.lblOyunBitti.TabIndex = 1;
            this.lblOyunBitti.Text = "label2";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(191, 202);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(35, 13);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.saha.ResumeLayout(false);
            this.saha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel saha;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblOyunBitti;
        private System.Windows.Forms.Label lblDurdu;
    }
}

