using ClinicConnect.Application.DTOs;

namespace ClinicConnect.Application.Interfaces
{
    public interface IClinicService
    {
        Task<ClinicDTO> Add(ClinicDTO doctor);
        Task<IEnumerable<ClinicDTO>> GetAll();
    }
}