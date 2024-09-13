using Hospital.Data.MsSql.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Data.MsSql.EntityTypeConfiguration
{
    /// <summary>
    /// Конфигурация для <see cref="LocationEntity"/>
    /// </summary>
    internal class LocationEntityConfiguration : IEntityTypeConfiguration<LocationEntity>
    {
        ///<inheritdoc/>
        public void Configure(EntityTypeBuilder<LocationEntity> builder)
        {
            builder.ToTable("Locations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Number)
                .IsRequired();

            builder.HasMany(x => x.Patients)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
