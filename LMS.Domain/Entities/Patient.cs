using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Patient : BaseEntity<Guid>
    {
        public string? Address { get; private set; }
        public string? Phone{ get; private set; }
        public string? Email { get; private set; }

    }
}
