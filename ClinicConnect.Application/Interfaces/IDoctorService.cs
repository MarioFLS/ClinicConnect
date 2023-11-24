using ClinicConnect.Application.DTOs;
using ClinicConnect.Domain.Entites;

namespace ClinicConnect.Application
{
    public interface IDoctorService
    {
        Task<DoctorDTO> Add(DoctorDTO doctor);
        Task<IEnumerable<DoctorDTO>> GetAll();
        Task<DoctorClinicAssociation> AssociateDoctorClinic(DoctorClinicAssociationDTO association);
    }
}