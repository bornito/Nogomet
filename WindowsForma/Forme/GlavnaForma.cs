using PodatkovniSloj;
using PodatkovniSloj.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForma.UserKontrole;

namespace WindowsForma
{
    public partial class GlavnaForma : Form
    {

        List<TeamEvent> userRangIgraciControlsList = new List<TeamEvent>();
        List<Matches> userRangStadioniControlsList = new List<Matches>();

        HashSet<string> userFavoriti = new HashSet<string>();

        private static SemaphoreSlim semafor = new SemaphoreSlim(1, 1); // Allows only one concurrent access.

        public GlavnaForma()
        {
            InitializeComponent();
            Inicijaliziraj();
        }

        private void Inicijaliziraj()
        {
            Repozitorij.UcitajPostavke();
            Repozitorij.UcitajJezik();

            userFavoriti = Repozitorij.UcitajFavorite();

            NapuniPodatke();
            NapuniPodatkeIgraca();

            InicijalizirajDND();
        }

        private void InicijalizirajDND()
        {
            // Igraci

            pnlIgraci.DragEnter += PnlContainers_DragEnter;
            pnlIgraci.DragDrop += PnlPlayersContainer_DragDrop;

            // Igraci favoriti

            pnlFavoriti.DragEnter += PnlContainers_DragEnter;
            pnlFavoriti.DragDrop += PnlFavouritePlayersContainer_DragDrop;
        }

        // ddlReprezentacija

        private void ddlReprezentacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilePostavke.drzavaMomcadi = 
                ddlReprezentacija.SelectedItem.ToString().Substring(0, ddlReprezentacija.SelectedItem.ToString().IndexOf("(")).Trim();
            Repozitorij.SpremiPostavke();
            NapuniPodatkeIgraca();
        }

        // pnlIgraci DND

        private void PnlPlayersContainer_DragDrop(object sender, DragEventArgs e)
        {
            var playerInfo = (UCIgrac)e.Data.GetData(typeof(UCIgrac));

            if (playerInfo.Parent == pnlFavoriti)
            {
                playerInfo.odabraniIGrac = false;
                pnlIgraci.Controls.Add(playerInfo);

                userFavoriti.Remove(playerInfo.ImeFavorita);
            }
        }

        private void PnlContainers_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;

        // pnlFavoriti DND

        private void PnlFavouritePlayersContainer_DragDrop(object sender, DragEventArgs e)
        {
            var playerInfo = (UCIgrac)e.Data.GetData(typeof(UCIgrac));

            if (playerInfo.Parent == pnlIgraci && (pnlFavoriti.Controls.Count) < 3)
            {
                playerInfo.odabraniIGrac = true;
                pnlFavoriti.Controls.Add(playerInfo);

                userFavoriti.Add(playerInfo.ImeFavorita);
            }
        }

        private async void NapuniPodatkeIgraca()
        {
            pnlIgraci.Controls.Clear();
            pnlRangIgraci.Controls.Clear();
            pnlRangStadioni.Controls.Clear();
            pnlFavoriti.Controls.Clear();

            try
            {
                HashSet<Matches> matches = await Repozitorij.UcitajUtakmice();
                lblTest.Text = FilePostavke.drzavaMomcadi;

                StartingEleven player = new StartingEleven();
                TeamEvent rankedPlayer = new TeamEvent();
                Matches stadium = new Matches();

                HashSet<StartingEleven> playerList = new HashSet<StartingEleven>();
                HashSet<TeamEvent> rankedPlayerList = new HashSet<TeamEvent>();
                HashSet<Matches> rankedStadiumList = new HashSet<Matches>();

                HashSet<UCIgrac> userPlayerControls = new HashSet<UCIgrac>();
                HashSet<UCRang> userRankedPlayerControls = new HashSet<UCRang>();
                HashSet<UCStadion> userRankedStadiumControls = new HashSet<UCStadion>();

                userRangIgraciControlsList = new List<TeamEvent>();
                userRangStadioniControlsList = new List<Matches>();

                foreach (var players in matches)
                {
                    if (players.HomeTeamStatistics.Country == FilePostavke.drzavaMomcadi)
                    {
                        rankedStadiumList.Add(players);
                        foreach (var playerItem in players.HomeTeamStatistics.StartingEleven)
                        {
                            playerList.Add(playerItem);

                            foreach (var rankedItem in players.HomeTeamEvents)
                            {
                                rankedPlayerList.Add(rankedItem);
                            }
                        }
                        foreach (var playerItem in players.HomeTeamStatistics.Substitutes)
                        {
                            playerList.Add(playerItem);

                            foreach (var rankedItem in players.HomeTeamEvents)
                            {
                                rankedPlayerList.Add(rankedItem);
                            }
                        }
                    }
                    if (players.AwayTeamStatistics.Country == FilePostavke.drzavaMomcadi)
                    {
                        rankedStadiumList.Add(players);
                        foreach (var playerItem in players.AwayTeamStatistics.StartingEleven)
                        {
                            playerList.Add(playerItem);

                            foreach (var rankedItem in players.AwayTeamEvents)
                            {
                                rankedPlayerList.Add(rankedItem);
                            }
                        }
                        foreach (var playerItem in players.AwayTeamStatistics.Substitutes)
                        {
                            playerList.Add(playerItem);

                            foreach (var rankedItem in players.AwayTeamEvents)
                            {
                                rankedPlayerList.Add(rankedItem);
                            }
                        }
                    }
                }

                // Igraci

                IEnumerable<StartingEleven> sortedPlayers = playerList.OrderBy(item => item.ShirtNumber);

                foreach (var playerItem in sortedPlayers)
                {
                    rankedPlayer = new TeamEvent();
                    foreach (var rankedItem in rankedPlayerList)
                    {
                        if (playerItem.Name == rankedItem.Player)
                        {
                            string rankedPlayerName = rankedItem.Player;
                            rankedPlayerName = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(rankedPlayerName.ToLower());
                            rankedPlayer.Player = rankedPlayerName;
                            switch (rankedItem.TypeOfEvent)
                            {
                                case "goal":
                                    rankedPlayer.Goals++;
                                    break;
                                case "yellow-card":
                                    rankedPlayer.YellowCards++;
                                    break;
                            }
                        }
                    };

                    if (!(rankedPlayer.Goals == 0 && rankedPlayer.YellowCards == 0))
                    {
                        userRankedPlayerControls.Add(new UCRang(rankedPlayer));
                        userRangIgraciControlsList.Add(rankedPlayer);
                    }
                    string playerName = playerItem.Name;
                    playerName = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(playerName.ToLower());
                    playerItem.Name = playerName;
                    userPlayerControls.Add(new UCIgrac(playerItem));
                }

                // Nerangirani igraci

                foreach (var unrankedplayerItem in userPlayerControls)
                {
                    pnlIgraci.Controls.Add(unrankedplayerItem);

                    // Favoriti 

                    foreach (var favouriteItem in userFavoriti)
                    {
                        if (unrankedplayerItem.Igrac.Name == favouriteItem)
                        {
                            unrankedplayerItem.odabraniIGrac = true;
                            pnlFavoriti.Controls.Add(unrankedplayerItem);
                        }
                    }
                }

                // Rang lista igraca

                IEnumerable<UCRang> sortedRankedPlayer1 = userRankedPlayerControls.OrderBy(Item => -Item.Igrac.YellowCards);
                IEnumerable<UCRang> sortedRankedPlayer = sortedRankedPlayer1.OrderBy(Item => -Item.Igrac.Goals);
                foreach (var rankedPlayerItem in sortedRankedPlayer)
                {
                    pnlRangIgraci.Controls.Add(rankedPlayerItem);
                }

                // Stadioni

                IEnumerable<Matches> sortedStadium = rankedStadiumList.OrderBy(item => -item.Attendance);

                foreach (var stadiumItem in sortedStadium)
                {
                    userRankedStadiumControls.Add(new UCStadion(stadiumItem));
                    userRangStadioniControlsList.Add(stadiumItem);
                }

                foreach (var rankedStadiumItem in userRankedStadiumControls)
                {
                    pnlRangStadioni.Controls.Add(rankedStadiumItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lblInfo.Text = ex.Message;
            }
        }

        private async void NapuniPodatke()
        {
            try
            {
                HashSet<Teams> teams = await Repozitorij.UcitajMomcadi();

                foreach (var orderedTeam in teams)
                {
                    ddlReprezentacija.Items.Add(orderedTeam);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // lblInfo.Text = ex.Message;
            }
        }

        // Glavna forma zatvaranje

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Na engleskom

            DialogResult result 
                = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Repozitorij.SpremiFavorite(userFavoriti);

            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        // Ispis buttoni

        private void btnPregledIspisa_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnOdaberiPisac_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            int x = 230;
            int y = 50;

            // Sortiranja igraca

            List<TeamEvent> sortedRankedPlayer1 = userRangIgraciControlsList.OrderBy(Item => -Item.YellowCards).ToList();
            List<TeamEvent> sortedRankedPlayer = sortedRankedPlayer1.OrderBy(Item => -Item.Goals).ToList();


            // Igraci

            e.Graphics.DrawString("RANKED PLAYERS", Font, Brushes.Black, x, y);
            for (int i = 0; i < sortedRankedPlayer.Count; i++)
            {
                e.Graphics.DrawString("Player: " + sortedRankedPlayer[i].Player + " - - -" +
                    " Goals: " + sortedRankedPlayer[i].Goals + " - - -" +
                    " Yellow cards: " + sortedRankedPlayer[i].YellowCards,
                    Font, Brushes.Black, x, y += 20);
            }

            // Stadioni

            e.Graphics.DrawString("RANKED STADIUMS", Font, Brushes.Black, x, y += 40);
            for (int i = 0; i < userRangStadioniControlsList.Count; i++)
            {
                e.Graphics.DrawString("Location: " + userRangStadioniControlsList[i].Location + " - - -" +
                    " Attendance: " + userRangStadioniControlsList[i].Attendance,
                    Font, Brushes.Black, x, y += 20);
            }
        }

        // postavke button
        private void btnPostavke_Click(object sender, EventArgs e)
        {
            Hide();
            Repozitorij.SpremiPostavke();
            Repozitorij.SpremiFavorite(userFavoriti);
            new PostavkeForma().Show();
        }


        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
