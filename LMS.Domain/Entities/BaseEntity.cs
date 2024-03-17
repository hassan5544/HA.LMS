using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class BaseEntity<T>
    {
        public T? Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeleteDate { get; set; }
        public int DeleteUser { get; set; }
    }
}
