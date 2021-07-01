using Abp.Application.Services.Dto;

namespace BhResturant.Products
{
    public class PagedProductResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }

    }
}