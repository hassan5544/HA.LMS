using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        Guid CreateAsync(T baseEo);
        void UpdateAsync(T baseEo, int UpdatedById);
        void DeleteAsync(T baseEo, int DeletedById);
    }
}
