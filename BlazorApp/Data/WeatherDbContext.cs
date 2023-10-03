using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class WeatherDbContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public WeatherDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
