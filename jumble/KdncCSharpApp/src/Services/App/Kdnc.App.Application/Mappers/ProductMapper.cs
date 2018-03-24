using Kdnc.App.Application.Models;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.Application.Mappers
{
    public class ProductMapper : IModelMapper<ProductDto, Product>
    {
        public ProductDto DtoFrom(Product domainEntity)
        {
            return new ProductDto()
            {
                Title = domainEntity.Title
            };
        }

        public Product EntityFrom(ProductDto dto)
        {
            return new Product()
            {
                Title = dto.Title
            };
        }
    }
}