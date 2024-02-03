using PodatkovniSloj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForma
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GlavnaForma());

            if (!File.Exists(Repozitorij.POSTAVKE_PATH) || !File.Exists(Repozitorij.FAVORITI_PATH))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "PostavkeForma"));
                File.WriteAllText(Repozitorij.POSTAVKE_PATH, Repozitorij.FAVORITI_PATH);
                File.Create(Repozitorij.FAVORITI_PATH).Close();
                Application.Run(new PostavkeForma());
            }
            if (!Directory.Exists(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Slike")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Slike"));
            }
            else
            {
                Application.Run(new ApplicationContext(new GlavnaForma()));
            }
        }
    }
}
