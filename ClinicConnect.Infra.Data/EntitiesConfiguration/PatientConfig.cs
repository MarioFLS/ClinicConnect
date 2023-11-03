using ClinicConnect.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicConnect.Infra.Data.EntitiesConfiguration
{
    public class PatientConfig
    {
        public static void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(20).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.MedicalInfo).HasMaxLength(250);
            builder.HasIndex(c => c.Phone).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}