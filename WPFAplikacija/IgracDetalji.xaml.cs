using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for IgracDetalji.xaml
    /// </summary>
    public partial class IgracDetalji : Window
    {
        public TeamEvent TeamEvent { get; set; }
        StartingEleven player = new StartingEleven();
        private bool _isClosing = false;

        public IgracDetalji(StartingEleven player)
        {
            InitializeComponent();
            this.player = player;
            Init();
        }
        private void Init()
        {
            string name = player.Name;
            name = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(name.ToLower());

            lblNameData.Content = name;
            lblShirtNumberData.Content = player.ShirtNumber;
            lblPositionData.Content = player.Position;
            lblCaptainData.Content = player.Captain;
            lblScoredGoalsData.Content = "";
            lblYellowCardsData.Content = "";

            var uriSource = new Uri(System.IO.Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"PodatkovniSloj/Slike/default.jpg"));
            PlayerImage.Source = new BitmapImage(uriSource);
            string[] filePaths = Directory.GetFiles(System.IO.Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"Slike/"));
            for (int i = 0; i < filePaths.Length; i++)
            {
                string exactFile = ($"{filePaths[i].Substring(filePaths[i].IndexOf("d/") + 2)}");
                string parsedFile = exactFile.Remove(exactFile.IndexOf('.'));
                if (name == parsedFile)
                {
                    uriSource = new Uri(System.IO.Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"Slike/{name}.jfif"));
                    PlayerImage.Source = new BitmapImage(uriSource);
                }
            }
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (!_isClosing)
                this.Close();
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            _isClosing = true;
            base.OnClosing(e);
        }
    }
}
