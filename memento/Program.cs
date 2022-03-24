// See https://aka.ms/new-console-template for more information
using memento;

Console.WriteLine("Début de la semaine");
Caretaker caretaker = new Caretaker();
caretaker.NewDay(22, CurrentWeather.WeatherType.Sunny, 63);
caretaker.NewDay(24, CurrentWeather.WeatherType.Cloudy, 72);
caretaker.NewDay(18, CurrentWeather.WeatherType.PartlyCloudy, 82);
caretaker.NewDay(26, CurrentWeather.WeatherType.Stormy, 3);
caretaker.NewDay(15, CurrentWeather.WeatherType.Sunny, 12);
caretaker.NewDay(23, CurrentWeather.WeatherType.Sunny, 99);
caretaker.NewDay(-8, CurrentWeather.WeatherType.Stormy, 86);

Console.WriteLine("Retour dans le temps à hier");
caretaker.Restore();