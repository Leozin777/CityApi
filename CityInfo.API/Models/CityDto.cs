namespace CityInfo.API.Models;

public class CityDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }

    public int NumberOfPointsOfInterest
    {
        get
        {
            return PointsOfInterests.Count;
        }
    }

    public ICollection<PointInterestDto> PointsOfInterests { get; set; } = new List<PointInterestDto>();
}
