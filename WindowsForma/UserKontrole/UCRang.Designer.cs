namespace WindowsForma.UserKontrole
{
    partial class UCRang
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
            this.pbIgracRang = new System.Windows.Forms.PictureBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblGolovi = new System.Windows.Forms.Label();
            this.lblZutiKartoni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgracRang)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIgracRang
            // 
            this.pbIgracRang.Location = new System.Drawing.Point(13, 14);
            this.pbIgracRang.Name = "pbIgracRang";
            this.pbIgracRang.Size = new System.Drawing.Size(70, 72);
            this.pbIgracRang.TabIndex = 0;
            this.pbIgracRang.TabStop = false;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(125, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblGolovi
            // 
            this.lblGolovi.AutoSize = true;
            this.lblGolovi.Location = new System.Drawing.Point(125, 37);
            this.lblGolovi.Name = "lblGolovi";
            this.lblGolovi.Size = new System.Drawing.Size(37, 13);
            this.lblGolovi.TabIndex = 2;
            this.lblGolovi.Text = "Golovi";
            // 
            // lblZutiKartoni
            // 
            this.lblZutiKartoni.AutoSize = true;
            this.lblZutiKartoni.Location = new System.Drawing.Point(125, 60);
            this.lblZutiKartoni.Name = "lblZutiKartoni";
            this.lblZutiKartoni.Size = new System.Drawing.Size(61, 13);
            this.lblZutiKartoni.TabIndex = 3;
            this.lblZutiKartoni.Text = "Žuti Kartoni";
            // 
            // UCRang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblZutiKartoni);
            this.Controls.Add(this.lblGolovi);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.pbIgracRang);
            this.Name = "UCRang";
            this.Size = new System.Drawing.Size(333, 102);
            ((System.ComponentModel.ISupportInitialize)(this.pbIgracRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIgracRang;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblGolovi;
        private System.Windows.Forms.Label lblZutiKartoni;
    }
}
