using Hospital.Domain.Models;

namespace Hospital.Core.Abstractions
{
    /// <summary>
    /// Репозиторий участков
    /// </summary>
    public interface ILocationRepository
    {
        /// <summary>
        /// Получить лоикацию по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Локация</returns>
        Task<Location> GetByIdAsync(int id);
    }
}
