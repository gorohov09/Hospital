using Hospital.Domain.Enums;
using MediatR;

namespace Hospital.Core.PatientRequests.Commands.CreatePatient
{
    /// <summary>
    /// Команда на создание пациента
    /// </summary>
    public class CreatePatientCommand : IRequest<int>
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = default!;

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// Отчество
        /// </summary>
        public string? Surname { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = default!;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Идентификатор участка
        /// </summary>
        public int LocationId { get; set; }
    }
}
