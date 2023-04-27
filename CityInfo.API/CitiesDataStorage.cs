using CityInfo.API.Models;

namespace CityInfo.API;

public class CitiesDataStorage
{
    public List<CityDto> Cities { get; set; }

    public static CitiesDataStorage Current { get; set; } = new CitiesDataStorage();

    public CitiesDataStorage()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "Torres",
                Description = "Cidade localizada no litoral do Rio Grande do Sul",
                PointsOfInterests = new List<PointInterestDto>()
                {
                    new PointInterestDto ()
                    {
                        Id = 1,
                        Name = "Morro do farol",
                        Description = "Um dos morros da cidade de torres"
                    },

                    new PointInterestDto ()
                    {
                        Id = 2,
                        Name = "Praia grande",
                        Description = "Conhecida também como a praia do meio"
                    }
                }
            },

            new CityDto()
            {
                Id = 2,
                Name = "Porto Alegre",
                Description = "Capital do Rio Grande do Sul",
                PointsOfInterests = new List<PointInterestDto>()
                {
                    new PointInterestDto()
                    {
                        Id = 3,
                        Name = "Estádio Beira-rio",
                        Description = "Estádio do Internacional",
                    },

                    new PointInterestDto()
                    {
                        Id = 4,
                        Name = "Arena do Grêmio",
                        Description = "Estádio do Grêmio"
                    }
                }
            },

            new CityDto()
            {
                Id = 3,
                Name = "São Paulo",
                Description = "Capital do estado de São Paulo",
                PointsOfInterests = new List<PointInterestDto>()
                {
                    new PointInterestDto()
                    {
                        Id = 5,
                        Name = "Morumbi",
                        Description = "Estádio do São Paulo"
                    },

                    new PointInterestDto()
                    {
                        Id = 6,
                        Name = "Neo Quimica Arena",
                        Description = "Estádio do Corinthians"
                    }
                }
            },

            new CityDto()
            {
                 Id = 4,
                 Name = "Rio de Janeiro",
                 Description = "Capital do Estado do Rio de Janeiro",
                 PointsOfInterests = new List<PointInterestDto>()
                 {
                    new PointInterestDto()
                    {
                        Id = 7,
                        Name = "Maracanã",
                        Description = "Estádio do Flamengo e do Fluminense"
                    },

                    new PointInterestDto()
                    {
                        Id = 8,
                        Name = "Pão de açucar",
                        Description = "Morros naturais conectados por um teleférico"
                    }
                }
            },

            new CityDto()
            {
                Id = 5,
                Name = "Gramado",
                Description = "Cidade localizada na serra gaucha",
                PointsOfInterests = new List<PointInterestDto>()
                {
                    new PointInterestDto()
                    {
                        Id = 9,
                        Name = "NBA Park",
                        Description = "Parque temático da NBA"
                    },

                    new PointInterestDto() 
                    {
                        Id = 10,
                        Name = "Mini mundo",
                        Description = "Um parque temático em miniatura"
                    }
                }
            }
        };
    }
}
