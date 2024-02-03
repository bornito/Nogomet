using PodatkovniSloj;
using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForma.UserKontrole
{
    public partial class UCRang : UserControl
    {
        public TeamEvent Igrac { get; private set; }

        public UCRang(TeamEvent igrac)
        {
            InitializeComponent();
            Igrac = igrac;
            PostaviVrijednosti(igrac);
        }

        private void PostaviVrijednosti(TeamEvent igrac)
        {
            lblIme.Text = igrac.Player;
            lblGolovi.Text = $"Golovi: {igrac.Goals.ToString()}";
            lblZutiKartoni.Text = $"Žuti kartoni: {igrac.YellowCards.ToString()}";
            pbIgracRang.Image = Repozitorij.GetSlika();
            igrac.RankedPicture = pbIgracRang.Image;
        }
    }
}
