using Abp.Domain.Entities;

namespace LeesStore.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}