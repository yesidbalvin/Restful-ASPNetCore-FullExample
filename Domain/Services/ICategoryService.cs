using Restful_ASPNetCore.Domain.Services.Communication;
using Restful_ASPNetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
