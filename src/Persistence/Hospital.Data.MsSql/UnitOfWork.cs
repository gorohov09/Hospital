using AutoMapper;
using Hospital.Core.Abstractions;
using Hospital.Data.MsSql.Repostitores;

namespace Hospital.Data.MsSql
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private IPatientRepository _patientRepository;
        private ILocationRepository _locationRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="mapper">Маппер</param>
        public UnitOfWork(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IDoctorRepository Doctors => throw new NotImplementedException();

        public IPatientRepository Patients
        {
            get
            {
                if (_patientRepository == null)
                    _patientRepository = new PatientRepository(_context, _mapper);

                return _patientRepository;
            }
        }

        public ILocationRepository Locations
        {
            get
            {
                if (_locationRepository == null)
                    _locationRepository = new LocationRepository(_context, _mapper);

                return _locationRepository;
            }
        }

        public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
