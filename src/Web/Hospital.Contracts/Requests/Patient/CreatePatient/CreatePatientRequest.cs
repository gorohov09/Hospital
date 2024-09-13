using Hospital.Domain.Enums;

namespace Hospital.Contracts.Requests.Patient.CreatePatient
{
    /// <summary>
    /// Запрос на создание пациента
    /// </summary>
    public class CreatePatientRequest
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
