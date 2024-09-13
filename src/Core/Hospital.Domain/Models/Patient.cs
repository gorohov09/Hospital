using Hospital.Domain.Enums;
using Hospital.Domain.Exceptions;

namespace Hospital.Domain.Models
{
    /// <summary>
    /// Пациент
    /// </summary>
    public class Patient : ModelBase
    {
        private string lastName = default!;
        private string firstName = default!;
        private string address = default!;
        private DateTime birthday;
        private Gender gender;
        private Location location = default!;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="surname">Отчество</param>
        /// <param name="address">Адрес</param>
        /// <param name="birthday">Дата рождения</param>
        /// <param name="gender">Пол</param>
        /// <param name="location">Участок</param>
        public Patient(
            string lastName,
            string firstName,
            string address,
            DateTime birthday,
            Gender gender,
            Location location,
            string? surname = null)
        {
            LastName = lastName;
            FirstName = firstName;
            Surname = surname;
            Address = address;
            Birthday = birthday;
            Gender = gender;
            Location = location;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get => lastName;
            private set
            {
                lastName = !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ApplicationExceptionBase("Пациент должен содержать фамилию");
            }
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get => firstName;
            private set
            {
                firstName = !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ApplicationExceptionBase("Пациент должен содержать имя");
            }
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? Surname { get; private set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get => address;
            private set
            {
                address = !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ApplicationExceptionBase("Пациент должен содержать адрес");
            }
        }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday
        {
            get => birthday;
            private set
            {
                birthday = value == default
                    ? throw new ApplicationExceptionBase("Пациент должен содержать дату рождения")
                    : value;
            }
        }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender
        {
            get => gender;
            private set
            {
                gender = value == default
                    ? throw new ApplicationExceptionBase("Пациент должен содержать пол")
                    : value;
            }
        }

        /// <summary>
        /// Участок
        /// </summary>
        public Location Location
        {
            get => location;
            private set
            {
                location = value == null
                    ? throw new ApplicationExceptionBase("Пациент должен содержать участок")
                    : value;
            }
        }
    }
}
