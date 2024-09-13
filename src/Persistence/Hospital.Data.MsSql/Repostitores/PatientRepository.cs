using AutoMapper;
using Hospital.Core.Abstractions;
using Hospital.Data.MsSql.Entities;
using Hospital.Domain.Models;

namespace Hospital.Data.MsSql.Repostitores
{
    ///<inheritdoc/>
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст БД</param>
        public PatientRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        ///<inheritdoc/>
        public void Add(Patient patient)
        {
            var entity = _mapper.Map<PatientEntity>(patient);
            _context.Patients.Add(entity);
        }
    }
}
