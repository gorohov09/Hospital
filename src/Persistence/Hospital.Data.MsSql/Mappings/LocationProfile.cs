using AutoMapper;
using Hospital.Data.MsSql.Entities;
using Hospital.Domain.Models;

namespace Hospital.Data.MsSql.Mappings
{
    /// <summary>
    /// Профиль участка
    /// </summary>
    public class LocationProfile : Profile
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public LocationProfile()
        {
            CreateMap<Location, LocationEntity>().ReverseMap();
        }
    }
}
