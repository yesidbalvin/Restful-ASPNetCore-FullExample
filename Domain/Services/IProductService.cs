using Restful_ASPNetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
