namespace ComputeExample.Controllers
{
  internal static class Common
  {
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private static readonly (Guid, String)[] Cities = new[]
    {
      (Guid.NewGuid(), "London"),
      (Guid.NewGuid(), "Birmingham"),
      (Guid.NewGuid(), "Manchester"),
    };

    internal static IQueryable<WeatherForecast> GetWeather()
    {
      return Enumerable.Range(1, 5).Select(index =>
      {
        var city = Cities[Random.Shared.Next(Cities.Length)];
        return new WeatherForecast
        {
          Date = DateTime.Now.AddDays(index),
          TemperatureC = Random.Shared.Next(-20, 55),
          Summary = Summaries[Random.Shared.Next(Summaries.Length)],
          CityId = city.Item1,
          City = new City
          {
            Id = city.Item1,
            Name = city.Item2,
          }
        };
      })
     .AsQueryable();
    }
  }
}
