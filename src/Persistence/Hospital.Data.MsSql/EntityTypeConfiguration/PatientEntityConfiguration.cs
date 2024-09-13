using Hospital.Data.MsSql.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Data.MsSql.EntityTypeConfiguration
{
    /// <summary>
    /// Конфигурация для <see cref="PatientEntity"/>
    /// </summary>
    internal class PatientEntityConfiguration : IEntityTypeConfiguration<PatientEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<PatientEntity> builder)
        {
            builder.ToTable("Patients");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.LastName)
                .IsRequired();

            builder.Property(x => x.FirstName)
                .IsRequired();

            builder.Property(x => x.Surname);

            builder.Property(x => x.Address)
                .IsRequired();

            builder.Property(x => x.Birthday)
                .IsRequired();

            builder.Property(x => x.Gender)
                .IsRequired();

            builder.HasOne(x => x.Location)
                .WithMany(x => x.Patients)
                .HasForeignKey(x => x.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
