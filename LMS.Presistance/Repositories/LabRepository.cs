using LMS.Domain.Entities;
using LMS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presistance.Repositories
{
    public class LabRepository : ILabRepository
    {
        private static readonly List<Lab> _items = new List<Lab>();

        public Guid CreateAsync(Lab baseEo)
        {
            _items.Add(baseEo);
            return baseEo.Id;
        }

        public void DeleteAsync(Lab baseEo, int DeletedById)
        {
            var selectedItem = _items.Where(x => x.Id == baseEo.Id).SingleOrDefault();
            if (selectedItem != null)
            {
                selectedItem.IsDeleted = true;
                selectedItem.DeleteDate = DateTime.Now;
                selectedItem.DeleteUser = DeletedById;
            }
            else
                throw new ArgumentException("Selected object dosnt exists");
        }

        public List<Lab> GetAll()
        {
            return _items;
        }

        public void UpdateAsync(Lab baseEo, int UpdatedById)
        {
            var selectedItem = _items.Where(x => x.Id == baseEo.Id).SingleOrDefault();
            if (selectedItem != null)
            {
                selectedItem.UpdateDate = DateTime.Now;
                selectedItem.UpdateUser = UpdatedById;

            }
            else
                throw new ArgumentException("Selected object dosnt exists");
        }
    }
}
