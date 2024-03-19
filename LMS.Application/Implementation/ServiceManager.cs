using LMS.Application.Services;
using LMS.Domain.Repositories;
using AutoMapper;

namespace LMS.Application.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IDoctorService> _doctorService;
        private readonly Lazy<ILabService> _labService;
        private readonly Lazy<ILabTestService> _labTestService;
        private readonly Lazy<IReportsService> _reportService;
        private readonly Lazy<IPatientService> _patientService;

        public ServiceManager(IRepositoryManager repositoryManager , IMapper mapper )
        {
            _doctorService = new Lazy<IDoctorService> (() => new DoctorService(repositoryManager , mapper));
            _labService = new Lazy<ILabService> (() => new LabService(repositoryManager , mapper));
            _labTestService = new Lazy<ILabTestService>(() => new LabTestService(repositoryManager, mapper));
            _patientService = new Lazy<IPatientService>(() => new PatientService(repositoryManager, mapper));
            _reportService = new Lazy<IReportsService>(() => new ReportService(repositoryManager, mapper));
        }

        public IDoctorService DoctorService => _doctorService.Value;

        public ILabService LabService => _labService.Value;

        public ILabTestService TestService => _labTestService.Value;

        public IReportsService ReportsService => _reportService.Value;

        public IPatientService PatientService => _patientService.Value;
    }
}
