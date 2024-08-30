using Microsoft.AspNetCore.Mvc;
using WebApplication14.Data;

namespace WebApplication14.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly WeatherDbContext context;
        public CityController(WeatherDbContext context)
        {
            this.context = context;
        }
        [HttpPost(Name = "CreateCity")]
        public async Task<City> CreateCityAsync(City city, CancellationToken
        cancellationToken)
        {
            await context.Cities.AddAsync(city, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return city;
        }
    }
}