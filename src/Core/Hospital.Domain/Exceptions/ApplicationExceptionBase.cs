namespace Hospital.Domain.Exceptions
{
    /// <summary>
    /// Базовое исключение для логики приложения
    /// </summary>
    public class ApplicationExceptionBase : ApplicationException
    {
        /// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="message">Сообщение</param>
		public ApplicationExceptionBase(string message)
            : base(message)
        {
        }

    }
}
