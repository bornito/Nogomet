using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj
{
    public class RepozitorijKonstante
    {
        // delimiter za razdvajanje

        public const char DEL = '|';

        // jezik aplikacije (lokalizacija i globalizacija) – mogući jezici su hrvatski i engleski.

        public const string HR = "hr";
        public const string EN = "en";

        // Odabir je potrebno spremiti u tekstualnu datoteku na disku i koristiti ga prilikom svakog sljedećeg pokretanja aplikacije

        public const string POSTAVKE_DEFAULT = "Croatian|True|";

        //public static string POSTAVKE_PATH = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Postavke/postavke.txt");
        //public static string FAVORITI_PATH = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Postavke/favoriti.txt");

        //public static string POSTAVKE_PATH = "Postavke/postavke.txt";
        //public static string FAVORITI_PATH = "Postavke/favoriti.txt";
    }
}
