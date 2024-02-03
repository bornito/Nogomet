using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using PodatkovniSloj.Modeli;
using System.Globalization;
using System.Threading;
using PodatkovniSloj.Konstante;
using Newtonsoft.Json;
using RestSharp;

namespace PodatkovniSloj
{
    public class Repozitorij
    {

        //Postavke
        // Odabir je potrebno spremiti u tekstualnu datoteku na disku i koristiti ga prilikom svakog sljedećeg pokretanja aplikacije.

        public static string POSTAVKE_PATH = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Postavke/postavke.txt");
        public static string FAVORITI_PATH = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Postavke/favoriti.txt");

        public static void SpremiPostavke()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(FilePostavke.jezikSucelja).Append(RepozitorijKonstante.DEL)
              .Append(FilePostavke.spolMomcadi).Append(RepozitorijKonstante.DEL)
              .Append(FilePostavke.drzavaMomcadi).Append(RepozitorijKonstante.DEL)
              .Append(FilePostavke.drzavaMomcadiProtivnika).Append(RepozitorijKonstante.DEL)
              .Append(FilePostavke.indeksDrzave).Append(RepozitorijKonstante.DEL)
              .Append(FilePostavke.indeksDrzaveProtivnika).Append(RepozitorijKonstante.DEL)
              .Append(FilePostavke.rezolucijaEkrana).Append(RepozitorijKonstante.DEL);

            File.WriteAllText(POSTAVKE_PATH, sb.ToString()); // try catche?
        }

        public static List<string> UcitajPostavke()
        {
            string[] linije = File.ReadAllLines(POSTAVKE_PATH); // try catche

            List<string> lista = new List<string>();

            foreach (string line in linije)
            {
                //string[] podaci = line.Split(RepozitorijKonstante.DEL);

                string[] podaci = line.Split('|');

                lista.Add(podaci[0]);
                lista.Add(podaci[1]);
                lista.Add(podaci[2]);
                lista.Add(podaci[3]);
                lista.Add(podaci[4]);
                lista.Add(podaci[5]);
                lista.Add(podaci[6]);

                FilePostavke.jezikSucelja = podaci[0];
                FilePostavke.spolMomcadi = Convert.ToBoolean(podaci[1]);
                FilePostavke.drzavaMomcadi = podaci[2];
                FilePostavke.drzavaMomcadiProtivnika = podaci[3];
                FilePostavke.indeksDrzave = int.Parse(podaci[4]);
                FilePostavke.indeksDrzaveProtivnika = int.Parse(podaci[5]);
                FilePostavke.rezolucijaEkrana = podaci[6];
            }

            return lista;
        }



        // Favoriti
        // Odabire je potrebno pohraniti u tekstualnu datoteku i koristiti prilikom sljedećih učitavanja aplikacije.

        public static HashSet<string> UcitajFavorite()
        {
            string[] linije = File.ReadAllLines(FAVORITI_PATH); // try catche

            HashSet<string> lista = new HashSet<string>();

            foreach (string linija in linije)
            {
                lista.Add(linija);
            }

            FilePostavke.favoriti = lista;

            return lista;
        }

        public static void SpremiFavorite(HashSet<string> favoriti)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in favoriti)
            {
                sb.AppendLine(item);
            }

            File.WriteAllText(FAVORITI_PATH, sb.ToString()); // try catche?
        }

        // Drzave 

        public static Task<HashSet<Teams>> UcitajMomcadi()
        {
            // Ucitaj s datoteke - ako nema sa weba
            if (File.Exists(APIMuskiKonstante.MUSKI_MOMCADI) && File.Exists(APIZenskiKonstante.ZENSKI_MOMCADI)) 
            {
                if (FilePostavke.spolMomcadi) // zenske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIZenskiKonstante.ZENSKI_MOMCADI))
                        {
                            var json = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<HashSet<Teams>>(json);
                        }
                    });
                }
                else // muske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIMuskiKonstante.MUSKI_MOMCADI))
                        {
                            var json = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<HashSet<Teams>>(json);
                        }
                    });
                }
            }
            else // ucitaj s weba
            {
                if (FilePostavke.spolMomcadi) // zenske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIZenskiKonstante.ZENSKI_MOMCADI))
                        {
                            var apiKlijent = new RestClient(APIZenskiKonstante.ZENSKE_MOMCADI_WEB);
                            var response = apiKlijent.Execute<HashSet<Teams>>(new RestRequest());
                            return JsonConvert.DeserializeObject<HashSet<Teams>>(response.Content);
                        }
                    });
                }
                else // muski
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIMuskiKonstante.MUSKI_MOMCADI))
                        {
                            var apiKlijent = new RestClient(APIZenskiKonstante.ZENSKE_MOMCADI_WEB);
                            var response = apiKlijent.Execute<HashSet<Teams>>(new RestRequest());
                            return JsonConvert.DeserializeObject<HashSet<Teams>>(response.Content);
                        }
                    });
                }
            }
        }

        // Igraci

        public static Task<HashSet<Matches>> UcitajUtakmice()
        {
            // Ucitaj s datoteke - ako nema sa weba
            if (File.Exists(APIMuskiKonstante.MUSKI_UTAKMICE) && File.Exists(APIZenskiKonstante.ZENSKI_UTAKMICE))
            {
                if (FilePostavke.spolMomcadi) // zenske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIZenskiKonstante.ZENSKI_UTAKMICE))
                        {
                            var json = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<HashSet<Matches>>(json);
                        }
                    });
                }
                else // muski
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIMuskiKonstante.MUSKI_UTAKMICE))
                        {
                            var json = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<HashSet<Matches>>(json);
                        }
                    });
                }
            }
            else // ucitaj s weba
            {
                if (FilePostavke.spolMomcadi) // zenske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIZenskiKonstante.ZENSKE_UTAKMICE_WEB))
                        {
                            var apiKlijent = new RestClient(APIZenskiKonstante.ZENSKE_MOMCADI_WEB);
                            var response = apiKlijent.Execute<HashSet<Matches>>(new RestRequest());
                            return JsonConvert.DeserializeObject<HashSet<Matches>>(response.Content);
                        }
                    });
                }
                else // muske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIMuskiKonstante.MUSKI_UTAKMICE_WEB))
                        {
                            var apiKlijent = new RestClient(APIZenskiKonstante.ZENSKE_MOMCADI_WEB);
                            var response = apiKlijent.Execute<HashSet<Matches>>(new RestRequest());
                            return JsonConvert.DeserializeObject<HashSet<Matches>>(response.Content);
                        }
                    });
                }
            }
        }

        // Detalji 

        public static Task<HashSet<Results>> UcitajRezultateSusreta()
        {
            // Ucitaj s datoteke - ako nema sa weba
            if (File.Exists(APIMuskiKonstante.MUSKI_MOMCADI) && File.Exists(APIZenskiKonstante.ZENSKI_MOMCADI))
            {
                if (FilePostavke.spolMomcadi) // zenske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIZenskiKonstante.ZENSKI_MOMCADI))
                        {
                            var json = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<HashSet<Results>>(json);
                        }
                    });
                }
                else // muske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIMuskiKonstante.MUSKI_MOMCADI))
                        {
                            var json = reader.ReadToEnd();
                            return JsonConvert.DeserializeObject<HashSet<Results>>(json);
                        }
                    });
                }
            }
            else // ucitaj s weba
            {
                if (FilePostavke.spolMomcadi) // zenske
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIZenskiKonstante.ZENSKI_MOMCADI))
                        {
                            var apiKlijent = new RestClient(APIZenskiKonstante.ZENSKE_MOMCADI_WEB);
                            var response = apiKlijent.Execute<HashSet<Results>>(new RestRequest());
                            return JsonConvert.DeserializeObject<HashSet<Results>>(response.Content);
                        }
                    });
                }
                else // muski
                {
                    return Task.Run(() =>
                    {
                        using (StreamReader reader = new StreamReader(APIMuskiKonstante.MUSKI_MOMCADI))
                        {
                            var apiKlijent = new RestClient(APIZenskiKonstante.ZENSKE_MOMCADI_WEB);
                            var response = apiKlijent.Execute<HashSet<Results>>(new RestRequest());
                            return JsonConvert.DeserializeObject<HashSet<Results>>(response.Content);
                        }
                    });
                }
            }
        }

        // Ako neki igrač nema postavljenu sliku, treba prikazati neku zadanu sliku igrača.

        public static Image GetSlika()
        {
            return Resursi._default;
        }

        // jezik aplikacije (lokalizacija i globalizacija) – mogući jezici su hrvatski i engleski.

        public static void UcitajJezik()
        {
            if (FilePostavke.jezikSucelja == "Croatian")
            {
                PostaviKulturu(RepozitorijKonstante.EN);
            }
            else
            {
                PostaviKulturu(RepozitorijKonstante.HR);
            }
        }

        public static void PostaviKulturu(string jezik)
        {
            var kultura = new CultureInfo(jezik);

            Thread.CurrentThread.CurrentUICulture = kultura;
            Thread.CurrentThread.CurrentCulture = kultura;
        }
    }
}
