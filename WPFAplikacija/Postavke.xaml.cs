using PodatkovniSloj;
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
using System.Windows.Shapes;

namespace WPFAplikacija
{
    /// <summary>
    /// Interaction logic for Postavke.xaml
    /// </summary>
    public partial class Postavke : Window
    {
        public Postavke()
        {
            InitializeComponent();
            Inicijalizacija();
        }

        private void Inicijalizacija()
        {
            Repozitorij.UcitajPostavke();
            Repozitorij.UcitajJezik();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            FilePostavke.spolMomcadi = (bool)rbtnFemale.IsChecked;
            FilePostavke.jezikSucelja = (bool)rbtnEnglish.IsChecked ? "Croatian" : "Engleski";
            if ((bool)rbtn480p.IsChecked)
            {
                FilePostavke.rezolucijaEkrana = "480p";
            }
            else if ((bool)rbtn720p.IsChecked)
            {
                FilePostavke.rezolucijaEkrana = "720p";
            }
            else if ((bool)rbtn1080p.IsChecked)
            {
                FilePostavke.rezolucijaEkrana = "1080p";
            }
            else
            {
                FilePostavke.rezolucijaEkrana = "FullScreen";
            }
            Repozitorij.SpremiPostavke();

            new MainWindow().Show();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new MainWindow().Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Repozitorij.UcitajPostavke();
            Repozitorij.UcitajJezik();
            LoadGender();
            LoadLanguage();
            LoadResolution();
        }

        private void LoadGender()
        {
            if (FilePostavke.spolMomcadi)
            {
                rbtnFemale.IsChecked = true;
            }
            else
            {
                rbtnMale.IsChecked = true;
            }
        }

        private void LoadLanguage()
        {
            if (FilePostavke.jezikSucelja == "Croatian")
            {
                rbtnEnglish.IsChecked = true;
            }
            else
            {
                rbtnCroatian.IsChecked = true;
            }
        }

        private void LoadResolution()
        {
            switch (FilePostavke.rezolucijaEkrana)
            {
                case "480p":
                    rbtn480p.IsChecked = true;
                    break;
                case "720p":
                    rbtn720p.IsChecked = true;
                    break;
                case "1080p":
                    rbtn1080p.IsChecked = true;
                    break;
                case "FullScreen":
                    rbtnFullScreen.IsChecked = true;
                    break;
            }
        }

    }
}
