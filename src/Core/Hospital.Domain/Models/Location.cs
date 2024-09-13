using Hospital.Domain.Exceptions;

namespace Hospital.Domain.Models
{
    /// <summary>
    /// Участок
    /// </summary>
    public class Location : ModelBase
    {
        private int number;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="number">Номер</param>
        public Location(int number)
        {
            Number = number;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Location()
        {
        }

        /// <summary>
        /// Номер
        /// </summary>
        public int Number
        {
            get => number;
            private set => number = value > 0
                ? value
                : throw new ApplicationExceptionBase("Номер участка не может быть отрицательным");
        }
    }
}
