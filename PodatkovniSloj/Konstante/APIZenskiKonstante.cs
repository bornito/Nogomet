using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj.Konstante
{
    internal class APIZenskiKonstante
    {
        // Linkovi zene web

        public const string ZENSKE_MOMCADI_WEB =
            "https://worldcup-vua.nullbit.hr/women/teams/";

        public const string ZENSKE_MOMCADI_REZULTATI_WEB =
             "https://worldcup-vua.nullbit.hr/women/teams/results";

        public const string ZENSKE_UTAKMICE_WEB =
            "https://worldcup-vua.nullbit.hr/women/matches";

        public const string ZENSKE_UTAKMICE_DETALJI_WEB =
            "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=ENG";

        /*
        * Putanje do korištenih resursa (slike, tekstualne datoteke, ...) 
        * ne smiju biti hard-codirane. Treba koristiti relativne putanje. 
        */

        // Linkovi zene file

        public static string ZENSKI_MOMCADI
             = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/zenski_teams.json");

        public static string ZENSKI_REZULTAT
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/zenski_results.json");

        public static string ZENSKI_UTAKMICE
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/zenski_matches.json");

        public static string ZENSKI_GRUPNI_REZULTATI
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/zenski_group_results.json");
    }
}
