namespace WindowsForma.UserKontrole
{
    partial class UCIgrac
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
            this.pbIgracSlika = new System.Windows.Forms.PictureBox();
            this.lblBrojIgraca = new System.Windows.Forms.Label();
            this.lblImeIgraca = new System.Windows.Forms.Label();
            this.lblPozicijaIgraca = new System.Windows.Forms.Label();
            this.lblKapetan = new System.Windows.Forms.Label();
            this.lblFavorit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgracSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIgracSlika
            // 
            this.pbIgracSlika.Location = new System.Drawing.Point(20, 14);
            this.pbIgracSlika.Name = "pbIgracSlika";
            this.pbIgracSlika.Size = new System.Drawing.Size(74, 73);
            this.pbIgracSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIgracSlika.TabIndex = 0;
            this.pbIgracSlika.TabStop = false;
            // 
            // lblBrojIgraca
            // 
            this.lblBrojIgraca.AutoSize = true;
            this.lblBrojIgraca.Location = new System.Drawing.Point(120, 14);
            this.lblBrojIgraca.Name = "lblBrojIgraca";
            this.lblBrojIgraca.Size = new System.Drawing.Size(19, 13);
            this.lblBrojIgraca.TabIndex = 1;
            this.lblBrojIgraca.Text = "00";
            // 
            // lblImeIgraca
            // 
            this.lblImeIgraca.AutoSize = true;
            this.lblImeIgraca.Location = new System.Drawing.Point(120, 27);
            this.lblImeIgraca.Name = "lblImeIgraca";
            this.lblImeIgraca.Size = new System.Drawing.Size(24, 13);
            this.lblImeIgraca.TabIndex = 2;
            this.lblImeIgraca.Text = "Ime";
            // 
            // lblPozicijaIgraca
            // 
            this.lblPozicijaIgraca.AutoSize = true;
            this.lblPozicijaIgraca.Location = new System.Drawing.Point(120, 40);
            this.lblPozicijaIgraca.Name = "lblPozicijaIgraca";
            this.lblPozicijaIgraca.Size = new System.Drawing.Size(43, 13);
            this.lblPozicijaIgraca.TabIndex = 3;
            this.lblPozicijaIgraca.Text = "Pozicija";
            // 
            // lblKapetan
            // 
            this.lblKapetan.AutoSize = true;
            this.lblKapetan.Location = new System.Drawing.Point(120, 53);
            this.lblKapetan.Name = "lblKapetan";
            this.lblKapetan.Size = new System.Drawing.Size(47, 13);
            this.lblKapetan.TabIndex = 4;
            this.lblKapetan.Text = "Kapetan";
            // 
            // lblFavorit
            // 
            this.lblFavorit.AutoSize = true;
            this.lblFavorit.Location = new System.Drawing.Point(120, 66);
            this.lblFavorit.Name = "lblFavorit";
            this.lblFavorit.Size = new System.Drawing.Size(39, 13);
            this.lblFavorit.TabIndex = 5;
            this.lblFavorit.Text = "Favorit";
            // 
            // UCIgrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFavorit);
            this.Controls.Add(this.lblKapetan);
            this.Controls.Add(this.lblPozicijaIgraca);
            this.Controls.Add(this.lblImeIgraca);
            this.Controls.Add(this.lblBrojIgraca);
            this.Controls.Add(this.pbIgracSlika);
            this.Name = "UCIgrac";
            this.Size = new System.Drawing.Size(333, 102);
            ((System.ComponentModel.ISupportInitialize)(this.pbIgracSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIgracSlika;
        private System.Windows.Forms.Label lblBrojIgraca;
        private System.Windows.Forms.Label lblImeIgraca;
        private System.Windows.Forms.Label lblPozicijaIgraca;
        private System.Windows.Forms.Label lblKapetan;
        private System.Windows.Forms.Label lblFavorit;
    }
}
