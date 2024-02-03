namespace WindowsForma.UserKontrole
{
    partial class UCStadion
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
            this.lblBrojPosjetitelja = new System.Windows.Forms.Label();
            this.lblRepka = new System.Windows.Forms.Label();
            this.lblRepkaProtivnik = new System.Windows.Forms.Label();
            this.lblStadion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBrojPosjetitelja
            // 
            this.lblBrojPosjetitelja.AutoSize = true;
            this.lblBrojPosjetitelja.Location = new System.Drawing.Point(33, 16);
            this.lblBrojPosjetitelja.Name = "lblBrojPosjetitelja";
            this.lblBrojPosjetitelja.Size = new System.Drawing.Size(77, 13);
            this.lblBrojPosjetitelja.TabIndex = 0;
            this.lblBrojPosjetitelja.Text = "Broj posjetitelja";
            // 
            // lblRepka
            // 
            this.lblRepka.AutoSize = true;
            this.lblRepka.Location = new System.Drawing.Point(33, 42);
            this.lblRepka.Name = "lblRepka";
            this.lblRepka.Size = new System.Drawing.Size(48, 13);
            this.lblRepka.TabIndex = 1;
            this.lblRepka.Text = "Repka 1";
            // 
            // lblRepkaProtivnik
            // 
            this.lblRepkaProtivnik.AutoSize = true;
            this.lblRepkaProtivnik.Location = new System.Drawing.Point(33, 66);
            this.lblRepkaProtivnik.Name = "lblRepkaProtivnik";
            this.lblRepkaProtivnik.Size = new System.Drawing.Size(48, 13);
            this.lblRepkaProtivnik.TabIndex = 2;
            this.lblRepkaProtivnik.Text = "Repka 2";
            // 
            // lblStadion
            // 
            this.lblStadion.AutoSize = true;
            this.lblStadion.Location = new System.Drawing.Point(182, 42);
            this.lblStadion.Name = "lblStadion";
            this.lblStadion.Size = new System.Drawing.Size(43, 13);
            this.lblStadion.TabIndex = 3;
            this.lblStadion.Text = "Stadion";
            // 
            // UCStadion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStadion);
            this.Controls.Add(this.lblRepkaProtivnik);
            this.Controls.Add(this.lblRepka);
            this.Controls.Add(this.lblBrojPosjetitelja);
            this.Name = "UCStadion";
            this.Size = new System.Drawing.Size(333, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojPosjetitelja;
        private System.Windows.Forms.Label lblRepka;
        private System.Windows.Forms.Label lblRepkaProtivnik;
        private System.Windows.Forms.Label lblStadion;
    }
}
