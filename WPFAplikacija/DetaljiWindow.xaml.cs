using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using System.Windows.Resources;

namespace WPFAplikacija
{
    /// <summary>
    /// Interaction logic for DetaljiWindow.xaml
    /// </summary>
    public partial class DetaljiWindow : Window
    {
        Results result = new Results();
        private bool _isClosing = false;

        public DetaljiWindow(Results result)
        {
            InitializeComponent();
            this.result = result;
            Init();
        }

        private void Init()
        {
            lblCountryData.Content = result.Country;
            lblCodeData.Content = result.FifaCode;
            lblGamesPlayedData.Content = result.GamesPlayed;
            lblWinsData.Content = result.Wins;
            lblLossesData.Content = result.Losses;
            lblDrawsData.Content = result.Draws;
            lblGoalsForData.Content = result.GoalsFor;
            lblGoalsAgainstsData.Content = result.GoalsAgainst;
            lblGoalDifferentialData.Content = result.GoalDifferential;
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (!_isClosing)
                this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _isClosing = true;
            base.OnClosing(e);
        }
    }
}
