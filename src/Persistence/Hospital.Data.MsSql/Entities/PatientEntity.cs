using Hospital.Domain.Enums;
using Hospital.Domain.Models;

namespace Hospital.Data.MsSql.Entities
{
    /// <summary>
    /// Сущность пациента
    /// </summary>
    public class PatientEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

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
        /// Участок
        /// </summary>
        public LocationEntity Location { get; set; }

        /// <summary>
        /// Идентификкатор участка
        /// </summary>
        public int LocationId { get; set; }
    }
}
