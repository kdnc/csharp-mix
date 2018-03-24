using Kdnc.App.Application.Mappers;
using Kdnc.App.Application.Models;
using Kdnc.App.Domain.DataAccess;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.Application.Services
{
    public class ProductsApplicationService: IProductsApplicationService
    {
        private readonly IProductRepository productRepository;

        public ProductsApplicationService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        
        public void SaveProduct(ProductDto productDto)
        {
            ProductMapper modelMapper = new ProductMapper();
            Product productEntity = modelMapper.EntityFrom(productDto);
            Product result = this.productRepository.AddProduct(productEntity);
        }
    }
}