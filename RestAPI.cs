using System.Net.Http;
using System.Threading.Tasks;

// NuGet Paket um JSON Format zu verarbeiten
using Newtonsoft.Json;


namespace Bietigheim_Sunshine
{
    public class RestAPI
    {
        //http://api.weatherapi.com/v1/current.json?key=068148c7ca61436d91b182327221605&q=Italy&aqi=no

        public RestAPI(string url)
        {
            this.url = url + "?key=" + API_KEY;
        }


        //API Anfrage - async, weil Server nicht sofort antworten kann
        //Task: hält den Zustand der Anfrage (vorläufiges Resultat, man kann den Zustand der Anfrage erfragen)
        public async Task<WeatherResponse> getWeatherbyCountry(string country)
        {
            // Warten (await) solange bis das endültige Resultat der Anfrage vorliegt -> synchroner Ablauf
            var result = await client.GetStringAsync(this.url + "&q=" + country + "&api=no"); // gibt Task<string> zurück

            // result ist ein string im JSON Format -> Ziel ist es daraus ein C# Objekt zu generieren
            // NewtonSoft JSON Paket ermöglicht diese Konvertierung
            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(result);

            return weatherResponse;
        }

        private string url;
        private const string API_KEY = "068148c7ca61436d91b182327221605";

        // Erzeugen des .NET HTTPClients (wird nur 1x pro Prozess erzeugt)
        static readonly HttpClient client = new HttpClient();
    }
}
