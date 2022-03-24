using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class Caretaker
    {
        private List<Memento> lstWeather = new List<Memento>();

        private CurrentWeather weather;
        
        public void NewDay(int temp, CurrentWeather.WeatherType wt, int hum)
        {
            CurrentWeather cw = new CurrentWeather(temp, wt, hum);
            Console.WriteLine("Nouvelle journée: ");
            Console.WriteLine(cw.ToString());
            weather = cw;
            Save();
        }

        public void Save()
        {
            Console.WriteLine("Sauvegarde de la météo courante");
            Memento backup = weather.SaveWeather();
            lstWeather.Add(backup);

        }

        public void Restore()
        {
            Console.WriteLine("Restauration de la météo : ");
            Memento lastWeather = lstWeather.Last();
            lstWeather.Remove(lastWeather);
            weather.RestoreWeather(lstWeather.Last());
            Console.WriteLine(weather.ToString());
        }
    }
}
