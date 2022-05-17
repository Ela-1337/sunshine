using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bietigheim_Sunshine
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RestAPI Api = new RestAPI("http://api.weatherapi.com/v1/current.json");
            var call_response = Api.getWeatherbyCountry("England").GetAwaiter().GetResult();
            var feels_like = call_response.current.feelslike_c;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
