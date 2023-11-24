using ClinicConnect.Domain.Entites;
using MediatR;

namespace ClinicConnect.Application.Commands.DoctorCommand
{
    public class AssociateDoctorClinicCommand : IRequest<DoctorClinicAssociation>
    {
        public Guid DoctorId { get; set; }
        public Guid ClinicId { get; set; }
    }
}