using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj
{
    internal class APIMuskiKonstante
    {
        // Linkovi muski web

        public const string MUSKI_MOMCADI_WEB =
            "https://worldcup-vua.nullbit.hr/men/teams/";

        public const string MUSKI_MOMCADI_REZULTATI_WEB = 
            "https://worldcup-vua.nullbit.hr/men/teams/results";

        public const string MUSKI_UTAKMICE_WEB =
            "https://worldcup-vua.nullbit.hr/men/matches";

        public const string MUSKI_UTAKMICE_DETALJI_WEB =
            "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=ENG";

        /*
         * Putanje do korištenih resursa (slike, tekstualne datoteke, ...) 
         * ne smiju biti hard-codirane. Treba koristiti relativne putanje. 
         */

        // Linkovi muski file

        public static string MUSKI_MOMCADI
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/muski_teams.json");

        public static string MUSKI_REZULTAT
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/muski_results.json");

        public static string MUSKI_UTAKMICE
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/muski_matches.json");

        public static string MUSKI_GRUPNI_REZULTATI
            = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "JSON/muski_group_results.json");
    }
}
