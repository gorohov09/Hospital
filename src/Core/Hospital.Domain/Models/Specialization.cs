using Hospital.Domain.Exceptions;

namespace Hospital.Domain.Models
{
    /// <summary>
    /// Специализация
    /// </summary>
    public class Specialization : ModelBase
    {
        private string name = default!;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название</param>
        public Specialization(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Название
        /// </summary>
        public string Name
        {
            get => name;
            private set => name = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ApplicationExceptionBase("Название специализации не должно быть пустым");
        }
    }
}
