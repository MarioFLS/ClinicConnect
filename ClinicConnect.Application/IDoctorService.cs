using ClinicConnect.Application.DTOs;

namespace ClinicConnect.Application
{
    public interface IDoctorService
    {
        Task<DoctorDTO> Add(DoctorDTO doctor);
        Task<IEnumerable<DoctorDTO>> GetAll();
    }
}