using ClinicConnect.Domain.Entites;

namespace ClinicConnect.Domain.Interfaces.Repository
{
    public interface IDoctorRepository
    {
        Task<Doctor> CreateAsync(Doctor doctor);
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<DoctorClinicAssociation> AssociateDoctorClinic(DoctorClinicAssociation doctorClinicAssociation);
    }
}