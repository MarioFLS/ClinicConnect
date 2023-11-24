using ClinicConnect.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicConnect.Infra.Data.EntitiesConfiguration
{
    public class DoctorClinicAssociationConfig
    {
        public static void Configure(EntityTypeBuilder<DoctorClinicAssociation> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.DoctorId).HasColumnName("doctor_id").IsRequired();
            builder.Property(c => c.ClinicId).HasColumnName("clinic_id").IsRequired();

            builder.HasOne(c => c.Doctor)
            .WithMany(d => d.DoctorClinicAssociation)
            .HasForeignKey(c => c.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Clinic)
            .WithMany(d => d.DoctorClinicAssociation)
            .HasForeignKey(c => c.ClinicId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}