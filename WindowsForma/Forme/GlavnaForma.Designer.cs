namespace WindowsForma
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ddlReprezentacija = new System.Windows.Forms.ComboBox();
            this.lblReprezentacija = new System.Windows.Forms.Label();
            this.pnlIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIgraci = new System.Windows.Forms.Label();
            this.lblFavoriti = new System.Windows.Forms.Label();
            this.pnlFavoriti = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRangListaIgraca = new System.Windows.Forms.Label();
            this.pnlRangIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRangListaStadiona = new System.Windows.Forms.Label();
            this.pnlRangStadioni = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTest = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.btnPostavke = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnIspis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPregledIspisa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdaberiPisac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPostavke,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // ddlReprezentacija
            // 
            resources.ApplyResources(this.ddlReprezentacija, "ddlReprezentacija");
            this.ddlReprezentacija.FormattingEnabled = true;
            this.ddlReprezentacija.Name = "ddlReprezentacija";
            this.ddlReprezentacija.SelectedIndexChanged += new System.EventHandler(this.ddlReprezentacija_SelectedIndexChanged);
            // 
            // lblReprezentacija
            // 
            resources.ApplyResources(this.lblReprezentacija, "lblReprezentacija");
            this.lblReprezentacija.Name = "lblReprezentacija";
            // 
            // pnlIgraci
            // 
            resources.ApplyResources(this.pnlIgraci, "pnlIgraci");
            this.pnlIgraci.AllowDrop = true;
            this.pnlIgraci.Name = "pnlIgraci";
            // 
            // lblIgraci
            // 
            resources.ApplyResources(this.lblIgraci, "lblIgraci");
            this.lblIgraci.Name = "lblIgraci";
            // 
            // lblFavoriti
            // 
            resources.ApplyResources(this.lblFavoriti, "lblFavoriti");
            this.lblFavoriti.Name = "lblFavoriti";
            // 
            // pnlFavoriti
            // 
            resources.ApplyResources(this.pnlFavoriti, "pnlFavoriti");
            this.pnlFavoriti.AllowDrop = true;
            this.pnlFavoriti.Name = "pnlFavoriti";
            // 
            // lblRangListaIgraca
            // 
            resources.ApplyResources(this.lblRangListaIgraca, "lblRangListaIgraca");
            this.lblRangListaIgraca.Name = "lblRangListaIgraca";
            // 
            // pnlRangIgraci
            // 
            resources.ApplyResources(this.pnlRangIgraci, "pnlRangIgraci");
            this.pnlRangIgraci.Name = "pnlRangIgraci";
            // 
            // lblRangListaStadiona
            // 
            resources.ApplyResources(this.lblRangListaStadiona, "lblRangListaStadiona");
            this.lblRangListaStadiona.Name = "lblRangListaStadiona";
            // 
            // pnlRangStadioni
            // 
            resources.ApplyResources(this.pnlRangStadioni, "pnlRangStadioni");
            this.pnlRangStadioni.Name = "pnlRangStadioni";
            // 
            // lblTest
            // 
            resources.ApplyResources(this.lblTest, "lblTest");
            this.lblTest.Name = "lblTest";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // btnPostavke
            // 
            resources.ApplyResources(this.btnPostavke, "btnPostavke");
            this.btnPostavke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPostavke.Image = global::WindowsForma.Properties.Resources.postavke;
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIspis,
            this.btnPregledIspisa,
            this.btnOdaberiPisac});
            this.toolStripDropDownButton1.Image = global::WindowsForma.Properties.Resources.pisac;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // btnIspis
            // 
            resources.ApplyResources(this.btnIspis, "btnIspis");
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnPregledIspisa
            // 
            resources.ApplyResources(this.btnPregledIspisa, "btnPregledIspisa");
            this.btnPregledIspisa.Name = "btnPregledIspisa";
            this.btnPregledIspisa.Click += new System.EventHandler(this.btnPregledIspisa_Click);
            // 
            // btnOdaberiPisac
            // 
            resources.ApplyResources(this.btnOdaberiPisac, "btnOdaberiPisac");
            this.btnOdaberiPisac.Name = "btnOdaberiPisac";
            this.btnOdaberiPisac.Click += new System.EventHandler(this.btnOdaberiPisac_Click);
            // 
            // GlavnaForma
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblRangListaStadiona);
            this.Controls.Add(this.pnlRangStadioni);
            this.Controls.Add(this.lblRangListaIgraca);
            this.Controls.Add(this.pnlRangIgraci);
            this.Controls.Add(this.lblFavoriti);
            this.Controls.Add(this.pnlFavoriti);
            this.Controls.Add(this.lblIgraci);
            this.Controls.Add(this.pnlIgraci);
            this.Controls.Add(this.lblReprezentacija);
            this.Controls.Add(this.ddlReprezentacija);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GlavnaForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPostavke;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnIspis;
        private System.Windows.Forms.ToolStripMenuItem btnPregledIspisa;
        private System.Windows.Forms.ToolStripMenuItem btnOdaberiPisac;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox ddlReprezentacija;
        private System.Windows.Forms.Label lblReprezentacija;
        private System.Windows.Forms.FlowLayoutPanel pnlIgraci;
        private System.Windows.Forms.Label lblIgraci;
        private System.Windows.Forms.Label lblFavoriti;
        private System.Windows.Forms.FlowLayoutPanel pnlFavoriti;
        private System.Windows.Forms.Label lblRangListaIgraca;
        private System.Windows.Forms.FlowLayoutPanel pnlRangIgraci;
        private System.Windows.Forms.Label lblRangListaStadiona;
        private System.Windows.Forms.FlowLayoutPanel pnlRangStadioni;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog2;
    }
}

