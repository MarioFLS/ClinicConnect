using ClinicConnect.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ClinicConnect.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinic> Clinics { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Pega as configurações de mapeamento de entidades do assembly CleanArchMvcInfra.Data,
            // que é onde estão as classes de configuração de mapeamento de entidades. Baseados em: IEntityTypeConfiguration
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}