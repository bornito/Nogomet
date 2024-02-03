using PodatkovniSloj;
using PodatkovniSloj.Modeli;
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

namespace WindowsForma.UserKontrole
{
    public partial class UCIgrac : UserControl
    {
        public bool odabraniIGrac = false;
        public StartingEleven Igrac { get; private set; }
        public string ImeFavorita { get; set; }

        public UCIgrac(StartingEleven igrac)
        {
            InitializeComponent();
            Igrac = igrac;
            PostaviVrijednosti(igrac);
        }

        private void PostaviVrijednosti(StartingEleven igrac)
        {
            ImeFavorita = igrac.Name;
            lblImeIgraca.Text = igrac.Name;
            lblBrojIgraca.Text = igrac.ShirtNumber.ToString();
            lblPozicijaIgraca.Text = igrac.Position.ToString();
            lblKapetan.Text = igrac.Captain ? "Kapetan" : " ";
            lblFavorit.Text = odabraniIGrac ? "Favorit" : "Nije favorit";
            pbIgracSlika.Image = Repozitorij.GetSlika();

            string[] filePaths = 
                Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"Slike/"));
            for (int i = 0; i < filePaths.Length; i++)
            {
                string exactFile = ($"{filePaths[i].Substring(filePaths[i].IndexOf("d/") + 2)}");
                string parsedFile = exactFile.Remove(exactFile.IndexOf('.'));
                if (igrac.Name == parsedFile)
                {
                    pbIgracSlika.Image = 
                        Image.FromFile(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"Slike/{Igrac.Name}.jfif"));
                }

            }
            igrac.Picture = pbIgracSlika.Image;
        }

        private void UCIgrac_MouseDown(object sender, MouseEventArgs e)
        {
            UCIgrac igracInfo = sender as UCIgrac;

            if (e.Button == MouseButtons.Left)
            {
                igracInfo.DoDragDrop(igracInfo, DragDropEffects.Move);

                if (odabraniIGrac)
                {
                    lblFavorit.Text = "Favorit";
                }
                else
                {
                    lblFavorit.Text = "Nije favorit";
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = pbIgracSlika;

            PromjeniSlikuForma forma = new PromjeniSlikuForma(pictureBox);

            Image image = forma.GetUpdatedPicture().Image;

            if (forma.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = image;

                image.Save(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"Pictures/{Igrac.Name}.jpeg"));

                forma.Close();
            }
            else
            {
                forma.Close();
            }
        }
    }
}
