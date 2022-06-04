using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bietigheim_Sunshine
{
    class DBAccess
    {
        //Constructor
        public DBAccess()
        {
            this.CreateTable();
        }
        private void CreateTable()
        {
            // Connection zur Datenbank aufmachen
            adapter.Connection.Open();

            // Kommando mit Komandotext erzeugen
            var command = adapter.Connection.CreateCommand();
            command.CommandText =
                    @"
                CREATE TABLE IF NOT EXISTS WetterDatenTabelle (
	            ID INTEGER PRIMARY KEY,
	            APICallTime TEXT NOT NULL,
	            Country TEXT NOT NULL,
	            City TEXT NOT NULL,
	            temp REAL NOT NULL,
                wind REAL NOT NULL,
                humidity REAL NOT NULL,
                localtime TEXT NOT NULL
            );
            ";

            // Führen Kommando aus
            command.ExecuteNonQuery();

            // Schließen Verbindung wieder
            adapter.Connection.Close();
        }

        public void SetWeatherData(WeatherDBModel model)
        {
            adapter.Connection.Open();

            var command = adapter.Connection.CreateCommand();
            command.CommandText =
                @"
            INSERT INTO WetterDatenTabelle (APICallTime,Country,City,temp,wind,humidity,localtime)
               VALUES($calltime, $country, $city, $temp,$wind,$humidity, $localtime);
            ";

            command.Parameters.AddWithValue("$calltime", model.APICallTime);
            command.Parameters.AddWithValue("$country", model.Country);
            command.Parameters.AddWithValue("$city", model.City);
            command.Parameters.AddWithValue("$temp", model.temp);
            command.Parameters.AddWithValue("$wind", model.wind);
            command.Parameters.AddWithValue("$humidity", model.humidity);
            command.Parameters.AddWithValue("$localtime", model.localtime);

            command.ExecuteNonQuery();

            adapter.Connection.Close();
        }

        public List<WeatherDBModel> GetWeatherData()
        {
            var returnlist = new List<WeatherDBModel>();

            adapter.Connection.Open();

            var command = adapter.Connection.CreateCommand();
            command.CommandText =
                @"
            SELECT * FROM WetterDatenTabelle
            ";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var element = new WeatherDBModel();
                    element.APICallTime = DateTime.Parse(reader.GetString(1));
                    element.Country = reader.GetString(2);
                    element.City = reader.GetString(3);
                    element.temp = reader.GetDouble(4);
                    element.wind = reader.GetDouble(5);
                    element.humidity = reader.GetDouble(6);
                    element.localtime = reader.GetString(7);

                    returnlist.Add(element);
                }
            }

            adapter.Connection.Close();

            return returnlist;
        }

        private static readonly DBAdapter adapter = new DBAdapter();

    }
}
