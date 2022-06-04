using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bietigheim_Sunshine
{
    public class WeatherDBModel
    {
        public DateTime APICallTime { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double temp { get; set;}
        public double wind { get; set; }
        public double humidity { get; set; }
        public string localtime { get; set; }

    }
}
