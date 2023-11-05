using System.ComponentModel.DataAnnotations;


namespace ClinicConnect.Application.DTOs
{
    public class DoctorDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email é inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = default!;

        [RegularExpression(@"^([0-9]{9})$", ErrorMessage = "Invalid Phone Number.")]
        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Phone(ErrorMessage = "O telefone é inválido")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "O telefone é inválido")]
        public string Phone { get; set; } = default!;

        [MinLength(3, ErrorMessage = "A especialização deve ter no mínimo 3 caracteres")]
        public string Specialization { get; set; } = default!;
    }
}