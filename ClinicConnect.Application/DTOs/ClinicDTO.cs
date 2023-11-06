using System.ComponentModel.DataAnnotations;

namespace ClinicConnect.Application.DTOs
{
    public class ClinicDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email é inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "O endereço é obrigatório")]
        public string Address { get; set; } = default!;

        [RegularExpression(@"^([0-9]{9})$", ErrorMessage = "Invalid Phone Number.")]
        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Phone(ErrorMessage = "O telefone é inválido")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "O telefone é inválido")]
        public string Phone { get; set; } = default!;

    }
}