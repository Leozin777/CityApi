using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
[Route("api/cities")]
public class CitiesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<CityDto>> GetCities()
    {
        var cities = CitiesDataStorage.Current.Cities;

        return Ok(cities);
    }

    [HttpGet("{p_id}")]
    public ActionResult<CityDto> GetCity(int p_id)
    {
        var city = CitiesDataStorage.Current.Cities.FirstOrDefault(city => city.Id == p_id);

        if(city == null)
            return NotFound();

        return Ok(city);    
    }
}
