using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
[Route("api/cities/{p_cityId}/pointsofinterest")]
public class PointsOfInterestController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<PointInterestDto>> GetPointOfInterest(int p_cityId)
    {
        var city = CitiesDataStorage.Current.Cities.FirstOrDefault(city => city.Id == p_cityId);

        if (city == null)
            return NotFound();
        return Ok(city.PointsOfInterests);
    }

    [HttpGet("{p_pointOfInterestId}")]
    public ActionResult<PointInterestDto> GetPointOfInterestById(int p_cityId, int p_pointOfInterestId)
    {
        var city = CitiesDataStorage.Current.Cities.FirstOrDefault(city => city.Id == p_cityId);

        if(city == null)
            return NotFound();

        var pointInterest = city.PointsOfInterests.FirstOrDefault(PI => PI.Id == p_pointOfInterestId);

        if (pointInterest == null)
            return NotFound();

        return Ok(pointInterest);

    }
}
