using Restful_ASPNetCore.Domain.Repositories;
using Restful_ASPNetCore.Domain.Services;
using Restful_ASPNetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
