using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class RestaurantMenu
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Category { get; set; }

        public string? Description { get; set; }
        [Required]
        [Range(0, 9999, ErrorMessage = "{0} must be between {1} and {2}.")]
        public int Price { get; set; }
        public string? Img { get; set; }

    }
}