using Restful_ASPNetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
        void Remove(Category category);
    }
}
