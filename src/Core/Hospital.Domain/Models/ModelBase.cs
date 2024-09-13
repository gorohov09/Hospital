namespace Hospital.Domain.Models
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class ModelBase
    {
        /// <summary>
		/// Идентификатор сущности
		/// </summary>
		public int Id { get; protected set; }
    }
}
