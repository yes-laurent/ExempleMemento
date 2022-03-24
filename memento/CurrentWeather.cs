using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class CurrentWeather
    {
        private int Temperature { get; set; }

        private WeatherType Weather { get; set; }

        private int Humidity { get; set; }

        public enum WeatherType
        {
            Sunny,
            PartlyCloudy,
            Cloudy,
            Stormy,
        }

        public CurrentWeather(int temp, WeatherType wt, int humidity)
        {
            Temperature = temp;
            Weather = wt;
            Humidity = humidity;
        }

        public Memento SaveWeather()
        {
            return new Memento(Temperature, Weather, Humidity);
        }

        public void RestoreWeather(Memento memento)
        {
            Temperature = memento.Temperature;
            Weather = memento.Weather;
            Humidity = memento.Humidity;

        }

        public override string ToString()
        {
            return "Température: " + Temperature + "\nHumidité: " + Humidity + "\nType de météo: " + Weather;
        }
    }
}
