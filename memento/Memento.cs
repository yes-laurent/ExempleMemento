using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static memento.CurrentWeather;

namespace memento
{
    public class Memento
    {
        private int _temperature { get; set; }

        private WeatherType _weather { get; set; }

        private int _humidity { get; set; }

        public int Temperature
        {
            get { return _temperature; }
        }

        public WeatherType Weather
        {
            get { return _weather; }
        }

        public int Humidity
        {
            get { return _humidity; }
        }

        public Memento(int temperature, WeatherType weather, int humidity )
        {
            _temperature = temperature;
            _weather = weather;
            _humidity = humidity;
        }

    }
}
