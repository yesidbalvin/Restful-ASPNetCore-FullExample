using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restful_ASPNetCore.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
