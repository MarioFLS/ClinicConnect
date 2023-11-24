namespace ClinicConnect.Domain.Entites
{
    public class Doctor : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Specialization { get; private set; }

        public List<DoctorClinicAssociation> DoctorClinicAssociation { get; set; } = new List<DoctorClinicAssociation>();

        public Doctor(string name, string email, string phone, string specialization)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Specialization = specialization;
        }
    }
}