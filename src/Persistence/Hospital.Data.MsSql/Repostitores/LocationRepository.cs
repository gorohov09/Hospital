using AutoMapper;
using Hospital.Core.Abstractions;
using Hospital.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.MsSql.Repostitores
{
    ///<inheritdoc/>
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст БД</param>
        public LocationRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        ///<inheritdoc/>
        public async Task<Location> GetByIdAsync(int id)
        {
            var entity = await _context.Locations
                .FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Location>(entity);
        }
    }
}
