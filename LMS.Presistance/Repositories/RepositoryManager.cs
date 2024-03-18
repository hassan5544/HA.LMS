using LMS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Presistance.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ILabRepository> _labRepository;
        private readonly Lazy<ILabTestsRepoistory> _labTestRepository;
        private readonly Lazy<IReportsRepository> _repprtsRepository;
        private readonly Lazy<IPatientRepository> _patientRepository;
        private readonly Lazy<IDoctorRepository> _doctorRepository;

        public RepositoryManager()
        {
            _labRepository = new Lazy<ILabRepository>(() => new LabRepository());
            _labTestRepository = new Lazy<ILabTestsRepoistory>(() => new LabTestsRepository());
            _repprtsRepository = new Lazy<IReportsRepository>(() => new ReportsRepository());
            _patientRepository = new Lazy<IPatientRepository>(() => new PatientRepository());
            _doctorRepository = new Lazy<IDoctorRepository>(() => new DoctorRepository());
        }
        public ILabRepository Lab => _labRepository.Value;

        public ILabTestsRepoistory LabTests => _labTestRepository.Value;

        public IReportsRepository Reports => _repprtsRepository.Value;

        public IPatientRepository Patient => _patientRepository.Value;

        public IDoctorRepository Doctor => _doctorRepository.Value;
    }
}
