using Abp.Domain.Entities;

namespace BhResturant.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}