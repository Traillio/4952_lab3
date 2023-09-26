using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data
{
public static class SeedData 
{
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
                modelBuilder.Entity<City>().HasData(
            GetCities()
        );


    }
    public static List<City> GetCities() 
    {
        List<City>cities = new List<City>() 
        {
            // create some cities
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Calgary",
                Population = 1096833,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 3,
                CityName = "Victoria",
                Population = 344615,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Saskatoon",
                Population = 246376,
                ProvinceCode = "SK"
            }
        };

        return cities;
    }

    public static List<Province> GetProvinces() 
    {
        List<Province> provinces = new List<Province>() 
        {
            // create some provinces
            new Province {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            },
            new Province {
                ProvinceCode = "SK",
                ProvinceName = "Saskatchewan"
            }
        };

        return provinces;
    }
}
}