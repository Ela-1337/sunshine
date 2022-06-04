using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bietigheim_Sunshine
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }
        private async void Abfrage_Click(object sender, EventArgs e)
        {
            // API.getWeatherbyCountry();

            if (this.Anfrage_Land.Length == 0)
            {
                MessageBox.Show("Kein Land ausgewählt!");

                return;
            }

            var result = await API.getWeatherbyCountry(this.Anfrage_Land);

            UhrzeitTextBox.Text = result.location.localtime;
            TemperaturTextBox.Text = result.current.temp_c.ToString();
            WindTextBox.Text = result.current.wind_kph.ToString();
            LuftfeuchteTextBox.Text = result.current.humidity.ToString();

            IconBox.SizeMode = PictureBoxSizeMode.StretchImage;
            IconBox.Load("https:"+result.current.condition.icon);

            WeatherDBModel model = new WeatherDBModel {
                APICallTime = DateTime.Now,
                Country = this.Anfrage_Land,
                City = result.location.name,
                temp = result.current.temp_c,
                wind = result.current.wind_kph,
                humidity = result.current.humidity,
                localtime = result.location.localtime
                };

            DBAccess.SetWeatherData(model);

        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelRemoting.CreateExcel(DBAccess.GetWeatherData());
            MessageBox.Show("Excel exportiert!");
        }


        private void AbfrageAuswahlListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            this.Anfrage_Land = cmb.SelectedItem.ToString();
        }

        private static readonly DBAccess DBAccess = new DBAccess();
        private static readonly RestAPI API = new RestAPI("http://api.weatherapi.com/v1/current.json");

        private string Anfrage_Land = "";

       
    }
}
