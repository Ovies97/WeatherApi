namespace WeatherApi.Models
{
    public class WeatherResponse
    {
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Weather[] Weather { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
