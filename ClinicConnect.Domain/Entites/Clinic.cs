namespace ClinicConnect.Domain.Entites
{
    public class Clinic : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Email { get; private set; } = default!;
        public string Phone { get; private set; } = default!;
    }
}