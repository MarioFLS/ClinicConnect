namespace ClinicConnect.Domain.Entites
{
    public class Doctor : BaseEntity
    {
        public string Name { get; private set; } = default!;
        public string Email { get; private set; } = default!;
        public string Phone { get; private set; } = default!;
        public string Specialization { get; private set; } = default!;

        public Doctor(string name, string email, string phone, string specialization)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Specialization = specialization;
        }
    }
}