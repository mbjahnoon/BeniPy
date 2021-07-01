using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;


namespace LeesStore.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    [AutoMapTo(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
    }
}