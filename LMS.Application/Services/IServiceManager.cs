using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Services
{
    public interface IServiceManager
    {
        IDoctorService DoctorService { get; }
        ILabService LabService { get; }
        ILabTestService TestService { get; }
        IReportsService ReportsService { get; }
        IPatientService PatientService { get; }
    }
}
