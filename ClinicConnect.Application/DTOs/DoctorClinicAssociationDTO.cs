using System.ComponentModel.DataAnnotations;

namespace ClinicConnect.Application.DTOs
{
    public class DoctorClinicAssociationDTO
    {
        [Required(ErrorMessage = "O DoctorId é obrigatório")]
        public Guid DoctorId { get; set; }

        [Required(ErrorMessage = "O Clinic_Id é obrigatório")]
        public Guid ClinicId { get; set; }
    }
}