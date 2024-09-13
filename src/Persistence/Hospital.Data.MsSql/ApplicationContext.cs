using Hospital.Data.MsSql.Entities;
using Hospital.Data.MsSql.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.MsSql
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="options">Настройки</param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }

        /// <summary>
        /// Участки
        /// </summary>
        public DbSet<LocationEntity> Locations { get; set; }

        /// <summary>
        /// Пациенты
        /// </summary>
        public DbSet<PatientEntity> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LocationEntityConfiguration());
            builder.ApplyConfiguration(new PatientEntityConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
