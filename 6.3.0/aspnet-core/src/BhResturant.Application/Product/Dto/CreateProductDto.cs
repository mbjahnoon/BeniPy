using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BhResturant.Products.Dto
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
