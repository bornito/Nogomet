using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj.Modeli
{
    public class FilePostavke
    {
        // postavke
        public static string jezikSucelja;
        public static bool spolMomcadi;
        public static string drzavaMomcadi;
        public static string drzavaMomcadiProtivnika;        
        public static HashSet<string> favoriti;

        // rezolucija
        public static string rezolucijaEkrana;

        // indeksi drzava
        public static int indeksDrzave;
        public static int indeksDrzaveProtivnika;
    }
}
