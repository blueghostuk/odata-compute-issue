using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputeExample
{
  public class WeatherForecast
  {
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    [ForeignKey(nameof(City))]
    public Guid CityId { get; set; }
    public City City { get; set; }
  }
}