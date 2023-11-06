using ClinicConnect.Domain.Entites;

namespace ClinicConnect.Domain.Interfaces.Repository
{
    public interface IClinicRepository
    {
        Task<Clinic> CreateAsync(Clinic clinic);
        Task<IEnumerable<Clinic>> GetAllAsync();
    }
}