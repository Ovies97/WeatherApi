namespace WeatherApi.Models
{
    public class ForecastResponse
    {
        public List[] List { get; set; }
    }

    public class List
    {
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Weather[] Weather { get; set; }
        public string Dt_Txt { get; set; }
    }
}
