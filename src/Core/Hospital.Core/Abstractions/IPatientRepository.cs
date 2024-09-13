using Hospital.Domain.Models;

namespace Hospital.Core.Abstractions
{
    /// <summary>
    /// Репозиторий пациентов
    /// </summary>
    public interface IPatientRepository
    {
        void Add(Patient patient);
    }
}
