using Exceptions.Validation_Exception;
using LMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presistance.Repositories
{
    public class RepositoryBase<T> where T : BaseEntity<Guid>
    {
        private static readonly List<T> _items = new List<T>();

        public Guid CreateAsync(T baseEo)
        {
            _items.Add(baseEo);
            return baseEo.Id;
        }

        public void DeleteAsync(T baseEo, int DeletedById)
        {
            var selectedItem = _items.Where(x => x.Id == baseEo.Id).SingleOrDefault();
            if (selectedItem != null)
            {
                selectedItem.SetDeleted(DeletedById);
            }
            else
                throw new EntityNotExistsException(baseEo.Name);
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public void UpdateAsync(T baseEo, int UpdatedById)
        {
            var selectedItem = _items.Where(x => x.Id == baseEo.Id).SingleOrDefault();
            if (selectedItem != null)
            {
                //selectedItem.UpdateDate = DateTime.Now;
                //selectedItem.UpdateUser = UpdatedById;

            }
            else
                throw new EntityNotExistsException(baseEo.Name);
        }
    }
}
