using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ComputeExample.Controllers
{
  public class WeathersController : ODataController
  {
    [EnableQuery]
    public ActionResult<IQueryable<WeatherForecast>> Get()
    {
      return Ok(Common.GetWeather());
    }
  }
}
