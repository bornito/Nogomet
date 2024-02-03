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
    public partial class UCStadion : UserControl
    {
        public Matches Stadion { get; private set; }

        public UCStadion(Matches stadion)
        {
            InitializeComponent();
            Stadion = stadion;
            PostaviVrijednosti(Stadion);
        }

        private void PostaviVrijednosti(Matches stadion)
        {
            lblBrojPosjetitelja.Text = stadion.Attendance.ToString();
            lblRepka.Text = stadion.HomeTeamCountry;
            lblRepkaProtivnik.Text = stadion.AwayTeamCountry;
            lblStadion.Text = stadion.Location;
        }
    }
}
