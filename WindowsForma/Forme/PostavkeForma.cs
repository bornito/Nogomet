using PodatkovniSloj;
using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForma
{
    public partial class PostavkeForma : Form
    {
        public PostavkeForma()
        {
            InitializeComponent();

            Inicijaliziraj();

            this.KeyPreview = true;
            this.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                    new GlavnaForma().Show();
                }

            };
        }

        private void Inicijaliziraj()
        {
            Repozitorij.UcitajPostavke();
        }

        private void PostavkeForma_Load(object sender, EventArgs e)
        {
            Repozitorij.UcitajPostavke();
            Repozitorij.UcitajJezik();

            OsvjeziFormu();

            UcitajSpolMomcadi();
        }

        private void UcitajSpolMomcadi()
        {
            if (FilePostavke.spolMomcadi)
            {
                rbZene.Checked = true;
            }
            else
            {
                rbMuski.Checked = true;
            }
        }

        private void OsvjeziFormu()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // engleski poruka

            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                FilePostavke.spolMomcadi = rbZene.Checked;
                FilePostavke.drzavaMomcadi = String.Empty;
                Repozitorij.SpremiPostavke();
                new GlavnaForma().Show();
            }

        }

        private void btnJezik_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == RepozitorijKonstante.HR)
            {
                Repozitorij.PostaviKulturu(RepozitorijKonstante.EN);
                FilePostavke.jezikSucelja = "Croatian";
                OsvjeziFormu();
                UcitajSpolMomcadi();
            }
            else
            {
                Repozitorij.PostaviKulturu(RepozitorijKonstante.HR);
                FilePostavke.jezikSucelja = "Engleski";
                OsvjeziFormu();
                UcitajSpolMomcadi();
            }
        }

        private void PostavkeForma_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                new GlavnaForma().Show();
            }
        }
    }
}
