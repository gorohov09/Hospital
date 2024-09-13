namespace Hospital.Core.Abstractions
{
    /// <summary>
    /// Единица работы
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Доктора
        /// </summary>
        IDoctorRepository Doctors { get; }

        /// <summary>
        /// Пациенты
        /// </summary>
        IPatientRepository Patients { get; }

        /// <summary>
        /// Участки
        /// </summary>
        ILocationRepository Locations { get; }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
