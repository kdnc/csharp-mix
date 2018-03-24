using Kdnc.App.Application.Models;

namespace Kdnc.App.Application.Services
{
    public interface IProductsApplicationService
    {
        void SaveProduct(ProductDto productDto);
    }
}