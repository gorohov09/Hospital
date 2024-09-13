using Hospital.Domain.Exceptions;

namespace Hospital.Domain.Models
{
    /// <summary>
    /// Кабинет
    /// </summary>
    public class Office : ModelBase
    {
        private int number;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="number">Номер</param>
        public Office(int number)
        {
            Number = number;
        }

        /// <summary>
        /// Номер
        /// </summary>
        public int Number
        {
            get => number;
            private set => number = value > 0
                ? value
                : throw new ApplicationExceptionBase("Номер кабинета не может быть отрицательным");
        }
    }
}
