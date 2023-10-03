using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        
        public List<string>? Name { get; set; }

        public List<int>? Amount { get; set; }
        
        public int TotalPrice { get; set; }
    }
}