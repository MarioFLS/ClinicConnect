using ClinicConnect.Domain.Entites;
using MediatR;

namespace ClinicConnect.Application.Commands.DoctorCommand
{
    public class DoctorCommandPatterns : IRequest<Doctor>
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Specialization { get; set; } = default!;
    }
}