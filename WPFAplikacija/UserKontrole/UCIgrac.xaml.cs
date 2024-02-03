using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAplikacija.UserKontrole
{
    /// <summary>
    /// Interaction logic for UCIgrac.xaml
    /// </summary>
    public partial class UCIgrac : UserControl
    {
        StartingEleven player = new StartingEleven();

        public UCIgrac(StartingEleven igrac)
        {
            InitializeComponent();
            player = igrac;

            string name = igrac.Name;
            name = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(name.ToLower());
            lblPlayer.Content = name;
            lblShirtNumber.Content = igrac.ShirtNumber;
        }
        public string PlayerName { get; set; }
        public int ShirtNumber { get; set; }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new PlayerInfo(player).Show();
        }
    }
}
