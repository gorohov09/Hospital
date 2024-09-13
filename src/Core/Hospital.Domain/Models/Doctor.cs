using Hospital.Domain.Exceptions;

namespace Hospital.Domain.Models
{
    /// <summary>
    /// Доктор
    /// </summary>
    public class Doctor : ModelBase
    {
        private string fullName = default!;
        private Office office = default!;
        private Specialization specialization = default!;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="fullName">ФИО</param>
        /// <param name="office">Кабинет</param>
        /// <param name="specialization">Специализация</param>
        /// <param name="location">Участок</param>
        public Doctor(
            string fullName, 
            Office office, 
            Specialization specialization, 
            Location? location = null)
        {
            FullName = fullName;
            Office = office;
            Specialization = specialization;
            Location = location;
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FullName
        {
            get => fullName;
            private set
            {
                fullName = !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ApplicationExceptionBase("Доктор должен иметь ФИО");
            }
        }

        /// <summary>
        /// Кабинет
        /// </summary>
        public Office Office
        {
            get => office;
            private set
            {
                office = value == null
                    ? throw new ApplicationExceptionBase("Доктор должен иметь кабинет")
                    : value;
            }
        }

        /// <summary>
        /// Специализация
        /// </summary>
        public Specialization Specialization
        {
            get => specialization;
            private set
            {
                specialization = value == null
                    ? throw new ApplicationExceptionBase("Доктор должен иметь спецциализацию")
                    : value;
            }
        }

        /// <summary>
        /// Участок
        /// </summary>
        public Location? Location { get; private set; }
    }
}
