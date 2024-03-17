using LMS.Domain.Entities;
using LMS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presistance.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private static readonly List<Doctor> _items = new List<Doctor>();

        public Guid CreateAsync(Doctor baseEo)
        {
            _items.Add(baseEo);
            return baseEo.Id;
        }

        public void DeleteAsync(Doctor baseEo, int DeletedById)
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

        public List<Doctor> GetAll()
        {
            return _items;
        }

        public void UpdateAsync(Doctor baseEo, int UpdatedById)
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
