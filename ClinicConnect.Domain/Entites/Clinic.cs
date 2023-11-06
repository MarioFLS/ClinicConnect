namespace ClinicConnect.Domain.Entites
{
    public class Clinic : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public Clinic(string name, string address, string email, string phone)
        {
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }
    }
}