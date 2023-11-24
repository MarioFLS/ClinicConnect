using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicConnect.Domain.Entites
{
    public class DoctorClinicAssociation : BaseEntity
    {
        [ForeignKey("Doctor")]
        public Guid DoctorId { get; set; }
        [ForeignKey("Clinic")]
        public Guid ClinicId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        [ForeignKey("ClinicId")]
        public Clinic? Clinic { get; set; }

        public DoctorClinicAssociation(Guid doctorId, Guid clinicId)
        {
            DoctorId = doctorId;
            ClinicId = clinicId;
        }
    }
}