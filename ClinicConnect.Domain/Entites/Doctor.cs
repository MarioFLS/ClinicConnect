namespace ClinicConnect.Domain.Entites
{
    public class Doctor : BaseEntity
    {
        public string Name { get; private set; } = default!;
        public string Email { get; private set; } = default!;
        public string Phone { get; private set; } = default!;
        public string Specialization { get; private set; } = default!;
    }
}