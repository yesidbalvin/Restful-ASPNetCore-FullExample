using Microsoft.EntityFrameworkCore;
using Restful_ASPNetCore.Domain.Repositories;
using Restful_ASPNetCore.Models;
using Restful_ASPNetCore.Persistence.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
