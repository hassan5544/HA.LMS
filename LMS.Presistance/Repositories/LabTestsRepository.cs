using LMS.Domain.Entities;
using LMS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presistance.Repositories
{
    public class LabTestsRepository : ILabTestsRepoistory
    {
        private static readonly List<LabTest> _items = new List<LabTest>();

        public Guid CreateAsync(LabTest baseEo)
        {
            _items.Add(baseEo);
            return baseEo.Id;
        }

        public void DeleteAsync(LabTest baseEo, int DeletedById)
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

        public List<LabTest> GetAll()
        {
            return _items;
        }

        public void UpdateAsync(LabTest baseEo, int UpdatedById)
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
