using Abp.Application.Services;
using BhResturant.Products.Dto;

namespace BhResturant.Products
{
    public interface IProductAppService : IAsyncCrudAppService<ProductDto, int, PagedProductResultRequestDto, CreateProductDto, ProductDto>
    {
        
    }
}
