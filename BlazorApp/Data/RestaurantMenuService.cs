namespace BlazorApp.Data
{
    public class RestaurantMenuService
    {
        private static readonly List<RestaurantMenu> Menu = new ();

        public Task<RestaurantMenu[]> GetMenuAsync()
        {
            //return Task.FromResult(Menu);
            return Task.FromResult(Enumerable.Range(0, 5).Select(index => new RestaurantMenu
            {
                Name = Menu[index].Name,
                Category = Menu[index].Category,
                Description = Menu[index].Description,
                Price = Menu[index].Price,
                Img = Menu[index].Img,
            }).ToArray());
        }
    }
}