namespace WindowsForma
{
    partial class PromjeniSlikuForma
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
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPromjeniSliku = new System.Windows.Forms.Button();
            this.lblPromjeniSliku = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(12, 121);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(295, 289);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 70);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 70);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPromjeniSliku
            // 
            this.btnPromjeniSliku.Location = new System.Drawing.Point(200, 92);
            this.btnPromjeniSliku.Name = "btnPromjeniSliku";
            this.btnPromjeniSliku.Size = new System.Drawing.Size(107, 23);
            this.btnPromjeniSliku.TabIndex = 3;
            this.btnPromjeniSliku.Text = "Promjeni sliku";
            this.btnPromjeniSliku.UseVisualStyleBackColor = true;
            // 
            // lblPromjeniSliku
            // 
            this.lblPromjeniSliku.AutoSize = true;
            this.lblPromjeniSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromjeniSliku.Location = new System.Drawing.Point(13, 13);
            this.lblPromjeniSliku.Name = "lblPromjeniSliku";
            this.lblPromjeniSliku.Size = new System.Drawing.Size(160, 25);
            this.lblPromjeniSliku.TabIndex = 4;
            this.lblPromjeniSliku.Text = "Promjeni sliku";
            // 
            // PromjeniSlikuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 502);
            this.Controls.Add(this.lblPromjeniSliku);
            this.Controls.Add(this.btnPromjeniSliku);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbSlika);
            this.Name = "PromjeniSlikuForma";
            this.Text = "PromjeniSlikuForma";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPromjeniSliku;
        private System.Windows.Forms.Label lblPromjeniSliku;
    }
}