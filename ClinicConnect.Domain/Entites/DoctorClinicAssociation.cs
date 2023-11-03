namespace ClinicConnect.Domain.Entites
{
    public class DoctorClinicAssociation : BaseEntity
    {
        public Guid Doctor_Id { get; set; }
        public Guid Clinic_Id { get; set; }
        public Doctor Doctor { get; set; } = default!;
        public Clinic Clinic { get; set; } = default!;
    }
}