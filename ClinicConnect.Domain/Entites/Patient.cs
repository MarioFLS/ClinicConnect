namespace ClinicConnect.Domain.Entites
{
    public class Patient : BaseEntity
    {
        public string Name { get; private set; } = default!;
        public string Email { get; private set; } = default!;
        public string Phone { get; private set; } = default!;
        public DateTime DateOfBirth { get; private set; }
        public string? MedicalInfo { get; private set; }
    }
}