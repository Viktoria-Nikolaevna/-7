using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР7.DataModel;

namespace ЛР7.Classes
{
    public class ComplexWeatherInfo
    {
        private string _time;
        public string Time
        {
            get { return _time; }
            set { _time = value ?? throw new ArgumentNullException(nameof(_time)); }
        }
        private Type_of_weather _weather;
        public Type_of_weather Weather
        {
            get { return _weather; }
            set 
            {
                _weather = value ?? throw new ArgumentNullException(nameof(_weather));
            }
        }
        public double Temperatura { get; set; }
        public double Humidity { get; set; }
        public ComplexWeatherInfo() { }
        public ComplexWeatherInfo(string time, Type_of_weather weather, double temperatura, double humidity)
        {
            Time = time;
            Weather = weather;
            Temperatura = temperatura;
            Humidity = humidity;
        }
    }
}
