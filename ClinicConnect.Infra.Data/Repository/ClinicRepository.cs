using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace ClinicConnect.Infra.Data.Repository
{
    public class ClinicRepository : IClinicRepository
    {
        private readonly ApplicationDbContext _context;

        public ClinicRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Clinic> CreateAsync(Clinic clinic)
        {
            await _context.Clinics.AddAsync(clinic);
            await _context.SaveChangesAsync();
            return clinic;
        }

        public async Task<IEnumerable<Clinic>> GetAllAsync()
        {
            var clinics = await _context.Clinics.ToListAsync();
            return clinics;
        }
    }
}