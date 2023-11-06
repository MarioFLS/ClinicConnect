using ClinicConnect.Domain.Entites;
using MediatR;

namespace ClinicConnect.Application.Commands.ClinicCommand
{
    public class ClinicCommandPatterns : IRequest<Clinic>
    {
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
    }
}