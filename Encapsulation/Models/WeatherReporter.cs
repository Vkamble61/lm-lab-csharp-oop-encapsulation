using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private double newTemp;
        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
            newTemp = (9.0 / 5.0) * _temperature + 32;
        }

        public string GetWeatherReport()
        {
            return $"I am in {_location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {newTemp}.";
        }

        private string CheckLocation()
        {
            if (_location == "London")
            {
                return "🌦";
            }
            else if (_location == "California")
            {
                return "🌅";
            }
            else if (_location == "Cape Town")
            {
                return "🌤";
            }
            else
                return "🔆";
        }

        private string CheckTemperature()
        {
            if (_temperature > 30)
            {
                return "It's too hot 🥵!";
            }
            else if (_temperature < 10)
            {
                return "It's too cold 🥶!";
            }
            else
                return "Ahhh...it's just right 😊!";
        }

    }
}

