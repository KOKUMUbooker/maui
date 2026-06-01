namespace WeatherClient.Models;

public class WeatherData
{
    public int Temperature { get; set; }
    public int Precipitation { get; set; }
    public int Humidity { get; set; }
    public int Wind { get; set; }
    public WeatherType Condition { get; set; }
}