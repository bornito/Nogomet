namespace WindowsForma
{
    partial class PostavkeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostavkeForma));
            this.lblJezik = new System.Windows.Forms.Label();
            this.lblPrvenstvo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.rbZene = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnJezik = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJezik
            // 
            resources.ApplyResources(this.lblJezik, "lblJezik");
            this.lblJezik.Name = "lblJezik";
            // 
            // lblPrvenstvo
            // 
            resources.ApplyResources(this.lblPrvenstvo, "lblPrvenstvo");
            this.lblPrvenstvo.Name = "lblPrvenstvo";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.rbMuski);
            this.groupBox2.Controls.Add(this.rbZene);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rbMuski
            // 
            resources.ApplyResources(this.rbMuski, "rbMuski");
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // rbZene
            // 
            resources.ApplyResources(this.rbZene, "rbZene");
            this.rbZene.Checked = true;
            this.rbZene.Name = "rbZene";
            this.rbZene.TabStop = true;
            this.rbZene.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOdustani
            // 
            resources.ApplyResources(this.btnOdustani, "btnOdustani");
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnJezik
            // 
            resources.ApplyResources(this.btnJezik, "btnJezik");
            this.btnJezik.Name = "btnJezik";
            this.btnJezik.UseVisualStyleBackColor = true;
            this.btnJezik.Click += new System.EventHandler(this.btnJezik_Click);
            // 
            // PostavkeForma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnJezik);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPrvenstvo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblJezik);
            this.Name = "PostavkeForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PostavkeForma_FormClosing_1);
            this.Load += new System.EventHandler(this.PostavkeForma_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJezik;
        private System.Windows.Forms.Label lblPrvenstvo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.RadioButton rbZene;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnJezik;
    }
}