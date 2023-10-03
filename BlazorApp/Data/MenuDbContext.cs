using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class MenuDbContext : DbContext
    {
        public DbSet<RestaurantMenu> RestaurantMenus { get; set; }
        //public List<RestaurantMenu> FoodMenus { get; set; }
        //public List<RestaurantMenu> BeverageMenus { get; set; }

        public MenuDbContext(DbContextOptions options) : base(options)
        {
            //FoodMenus = RestaurantMenus.Where(menu => menu.Category == "Food").ToList();
            //BeverageMenus = RestaurantMenus.Where(menu => menu.Category == "Beverage").ToList();
        }
    }

    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderDbContext(DbContextOptions options) : base(options)
        {
  
        }
    }
}
