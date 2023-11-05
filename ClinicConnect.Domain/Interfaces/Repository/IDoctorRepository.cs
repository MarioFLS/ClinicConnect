using ClinicConnect.Domain.Entites;

namespace ClinicConnect.Domain.Interfaces.Repository
{
    public interface IDoctorRepository
    {
        Task<Doctor> CreateAsync(Doctor doctor);
        /* Task UpdateAsync(Doctor doctor);
        Task<Doctor?> GetByIdAsync(Guid id); */
        Task<IEnumerable<Doctor>> GetAllAsync();
        /* Task<bool> ExistsAsync(Guid id); */
    }
}