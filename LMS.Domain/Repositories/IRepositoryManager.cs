using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Repositories
{
    public interface IRepositoryManager
    {
        ILabRepository Lab { get; }
        ILabTestsRepoistory LabTests { get; }
        IReportsRepository Reports { get; }
        IPatientRepository Patient { get; }
        IDoctorRepository Doctor { get; }

    }
}
