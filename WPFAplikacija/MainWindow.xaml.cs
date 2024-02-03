using PodatkovniSloj;
using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using WpfAnimatedGif;
using WPFAplikacija.UserKontrole;
using Path = System.IO.Path;

namespace WPFAplikacija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HashSet<Results> rezultatiSusreta = new HashSet<Results>();

        HashSet<Matches> susretiRepki = new HashSet<Matches>();

        HashSet<StartingEleven> pocetnaPostava = new HashSet<StartingEleven>();

        Results drzava = new Results();

        public MainWindow()
        {
            InitializeComponent();
            Inicijaliziraj();
        }

        private void Inicijaliziraj()
        {
            UcitajRezoluciju();

            Repozitorij.UcitajPostavke();
            Repozitorij.UcitajJezik();

            UcitajPodatke();
        }

        /*
         * Obavezno je ispravno odraditi sva moguća pojavljivanja iznimki. 
         * Aplikacije se ne smiju rušiti nakon pokretanja. 
         * Dovoljno je ispisati poruku (dijaloški okvir ili nešto slično) 
         * da se dogodila pogreška (npr. poziv prema API-ju vrati grešku). 
         */

        private async void UcitajPodatke()
        {
            try
            {
                rezultatiSusreta = await Repozitorij.UcitajRezultateSusreta();

                foreach (var item in rezultatiSusreta)
                {
                    ddlRepka.Items.Add(rezultatiSusreta);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UcitajRezoluciju()
        {
            switch (FilePostavke.rezolucijaEkrana)
            {
                case "480p":
                    Height = 480;
                    Width = 800;
                    break;

                case "720p":
                    Height = 720;
                    Width = 1280;
                    break;

                case "1080p":
                    Height = 1080;
                    Width = 1920;
                    break;

                case "FullScreen":
                    WindowState = WindowState.Maximized;
                    break;
            }
        }

        private void btnPostavke_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Postavke().Show();
        }

        private void btnRepkaProtivnikDetalji_Click(object sender, RoutedEventArgs e)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(System.IO.Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"PodatkovniSloj/Slike/ucitavanje.gif"));
            image.EndInit();
            ImageBehavior.SetAnimatedSource(ucitavanjeRepke, image);

            Task.Factory.StartNew(() => Thread.Sleep(1 * 1000))
            .ContinueWith((t) =>
            {
                drzava = new Results();
                foreach (var item in rezultatiSusreta)
                {
                    if (item.Country == FilePostavke.drzavaMomcadiProtivnika)
                    {
                        drzava = item;
                    }
                }
                new DetaljiWindow(drzava).Show();
                image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"PodatkovniSloj/Slike/prazno.png"));
                image.EndInit();
                ImageBehavior.SetAnimatedSource(ucitavanjeRepke, image);
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btnRepkaDetalji_Click(object sender, RoutedEventArgs e)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"PodatkovniSloj/Slike/ucitavanje.gif"));
            image.EndInit();


            Task.Factory.StartNew(() => Thread.Sleep(1 * 1000))
            .ContinueWith((t) =>
            {
                drzava = new Results();
                foreach (var item in rezultatiSusreta)
                {
                    if (item.Country == FilePostavke.drzavaMomcadi)
                    {
                        drzava = item;
                    }
                }
                new DetaljiWindow(drzava).Show();
                image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"PodatkovniSloj/Slike/prazno.png"));
                image.EndInit();
                ImageBehavior.SetAnimatedSource(ucitavanjeRepke, image);

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ddlRepka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ddlRepkaProtivnik.Items.Clear();

            FilePostavke.drzavaMomcadi = 
                ddlRepka.SelectedItem.ToString().Substring(0, ddlRepka.SelectedItem.ToString().IndexOf("(")).Trim();
            FilePostavke.indeksDrzave = ddlRepka.SelectedIndex;

            Repozitorij.SpremiPostavke();

            UcitajPodatkeIgraca();

            DodajIgrace();

            DodajIgraceProtivnika();
        }

        private void DodajIgrace()
        {
            Golman.Children.Clear();
            Obrana.Children.Clear();
            Centar.Children.Clear();
            Napad.Children.Clear();

            foreach (var item in susretiRepki) //mitem
            {
                if (item.HomeTeamStatistics.Country == FilePostavke.drzavaMomcadi)
                {
                    pocetnaPostava = new HashSet<StartingEleven>();

                    foreach (var i in item.HomeTeamStatistics.StartingEleven) // s11item
                    {
                        pocetnaPostava.Add(i);
                    }
                }
            }

            foreach (var item in pocetnaPostava) //s11item
            { 
                switch (item.Position)
                {
                    case Position.Defender:
                        Obrana.Children.Add(new UCIgrac(item));
                        break;
                    case Position.Forward:
                        Napad.Children.Add(new UCIgrac(item));
                        break;
                    case Position.Goalie:
                        Golman.Children.Add(new UCIgrac(item));
                        break;
                    case Position.Midfield:
                        Centar.Children.Add(new UCIgrac(item));
                        break;
                    default:
                        break;
                }

            }
        }

        private void DodajIgraceProtivnika()
        {
            GolmanProtivnik.Children.Clear();
            ObranaProtivnik.Children.Clear();
            CentarProtivnik.Children.Clear();
            NapadProtivnik.Children.Clear();

            foreach (var item in susretiRepki) //mitem
            {
                if (item.AwayTeamStatistics.Country == FilePostavke.drzavaMomcadiProtivnika)
                {
                    pocetnaPostava = new HashSet<StartingEleven>();

                    foreach (var i in item.AwayTeamStatistics.StartingEleven) // s11item
                    {
                        pocetnaPostava.Add(i);
                    }
                }
            }

            foreach (var item in pocetnaPostava) //s11item
            {
                switch (item.Position)
                {
                    case Position.Defender:
                        ObranaProtivnik.Children.Add(new UCIgrac(item));
                        break;
                    case Position.Forward:
                        NapadProtivnik.Children.Add(new UCIgrac(item));
                        break;
                    case Position.Goalie:
                        GolmanProtivnik.Children.Add(new UCIgrac(item));
                        break;
                    case Position.Midfield:
                        CentarProtivnik.Children.Add(new UCIgrac(item));
                        break;
                    default:
                        break;
                }

            }            
        }

        private async void UcitajPodatkeIgraca()
        {
            try
            {
                susretiRepki = await Repozitorij.UcitajUtakmice();
                foreach (var matchesItem in susretiRepki)
                {
                    if (matchesItem.HomeTeamStatistics.Country == FilePostavke.drzavaMomcadi)
                    {
                        ddlRepkaProtivnik.Items.Add(matchesItem.AwayTeamCountry);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlRepkaProtivnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ddlRepkaProtivnik.SelectedItem == null)
                return;

            FilePostavke.drzavaMomcadiProtivnika = ddlRepkaProtivnik.SelectedItem.ToString();
            FilePostavke.indeksDrzaveProtivnika = ddlRepkaProtivnik.SelectedIndex;
            Repozitorij.SpremiPostavke();
            DodajIgrace();
            DodajIgraceProtivnika();
            GetRezultati();
        }

        private void GetRezultati()
        {
            foreach (var resultItems in susretiRepki)
            {
                if (FilePostavke.drzavaMomcadi == resultItems.HomeTeamStatistics.Country)
                {
                    lblRezultatSusreta.Content = $"{resultItems.HomeTeam.Goals} : {resultItems.AwayTeam.Goals}";
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
