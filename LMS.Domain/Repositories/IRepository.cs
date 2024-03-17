using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<int> CreateAsync(T baseEo);
        Task<int> UpdateAsync(T baseEo);
        Task DeleteAsync(T baseEo);
    }
}
