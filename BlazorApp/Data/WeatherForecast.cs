using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class WeatherForecast
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "{0} must be between {1} and {2}.")]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required(ErrorMessage ="Summary is required.")]
        public string? Summary { get; set; }
    }
}