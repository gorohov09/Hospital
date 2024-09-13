namespace Hospital.Data.MsSql.Entities
{
    /// <summary>
    /// Сущность участкка
    /// </summary>
    public class LocationEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Пациенты
        /// </summary>
        public List<PatientEntity> Patients { get; set; }
    }
}
