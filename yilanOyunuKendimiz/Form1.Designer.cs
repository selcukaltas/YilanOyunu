namespace yilanOyunuKendimiz
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
            this.components = new System.ComponentModel.Container();
            this.pnlTahta = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblOyunBitti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTahta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTahta
            // 
            this.pnlTahta.BackColor = System.Drawing.Color.Sienna;
            this.pnlTahta.Controls.Add(this.lblAciklama);
            this.pnlTahta.Controls.Add(this.label1);
            this.pnlTahta.Controls.Add(this.lblOyunBitti);
            this.pnlTahta.Location = new System.Drawing.Point(12, 12);
            this.pnlTahta.Name = "pnlTahta";
            this.pnlTahta.Size = new System.Drawing.Size(400, 400);
            this.pnlTahta.TabIndex = 0;
            this.pnlTahta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTahta_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciklama.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAciklama.Location = new System.Drawing.Point(96, 291);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(200, 71);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "OYUNU BAŞLATMAK İÇİN F2 TUŞUNA BASINIZ..OYUN YÖN TUŞLARI İLE OYNANIR";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOyunBitti
            // 
            this.lblOyunBitti.BackColor = System.Drawing.Color.Transparent;
            this.lblOyunBitti.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunBitti.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOyunBitti.Location = new System.Drawing.Point(96, 123);
            this.lblOyunBitti.Name = "lblOyunBitti";
            this.lblOyunBitti.Size = new System.Drawing.Size(200, 94);
            this.lblOyunBitti.TabIndex = 2;
            this.lblOyunBitti.Text = "OYUN DURDU\r\nDevam etmek için F2 tuşuna basınız..)\r\n\r\n";
            this.lblOyunBitti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOyunBitti.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(96, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 94);
            this.label1.TabIndex = 3;
            this.label1.Text = "GameOver :(\r\n(Yeniden oynamak için F2 )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 430);
            this.Controls.Add(this.pnlTahta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTahta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTahta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOyunBitti;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label label1;
    }
}

