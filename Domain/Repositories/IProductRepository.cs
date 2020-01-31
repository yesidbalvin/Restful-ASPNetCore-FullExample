using Restful_ASPNetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
