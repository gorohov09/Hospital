using AutoMapper;
using Hospital.Data.MsSql.Entities;
using Hospital.Domain.Models;

namespace Hospital.Data.MsSql.Mappings
{
    /// <summary>
    /// Профиль пациента
    /// </summary>
    public class PatientProfile : Profile
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public PatientProfile()
        {
            CreateMap<PatientEntity, Patient>().ReverseMap()
                .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.Location.Id))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location));
        }
    }
}
