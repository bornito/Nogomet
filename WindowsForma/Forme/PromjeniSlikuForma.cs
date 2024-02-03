using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForma
{
    public partial class PromjeniSlikuForma : Form
    {
        public PromjeniSlikuForma(PictureBox slika)
        {
            InitializeComponent();
            Inicijaliziraj(slika);
        }

        private void Inicijaliziraj(PictureBox slika)
        {
            pbSlika.Image = slika.Image;
        }
        public PictureBox GetUpdatedPicture()
        {
            return pbSlika;
        }
        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Pictures|*.bmp;*.jpg;*.jfif;*.jpeg;*.png;|All files|*.*",
                InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Slike")

            };
            pbSlika.ImageLocation = ofd.FileName;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                GlavnaForma glavnaForma = new GlavnaForma();
                glavnaForma.Refresh();
                pbSlika.ImageLocation = ofd.FileName;
            }
        }

        private void FrmChangePicture_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlavnaForma glavnaForma = new GlavnaForma();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
