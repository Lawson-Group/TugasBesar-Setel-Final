using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace BikeLah_Setel
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
            Application.Run(new Login());

            
        }
    }
}
