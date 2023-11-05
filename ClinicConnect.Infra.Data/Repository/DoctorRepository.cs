using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace ClinicConnect.Infra.Data.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext _context;

        public DoctorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Doctor> CreateAsync(Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            var doctors = await _context.Doctors.ToListAsync();
            return doctors;
        }
    }
}