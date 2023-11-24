using ClinicConnect.Application.Commands.DoctorCommand;
using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using MediatR;

namespace ClinicConnect.Application.Handlers.DoctorHandlers
{
    public class AssociateDoctorClinicCommandHandler : IRequestHandler<AssociateDoctorClinicCommand, DoctorClinicAssociation>
    {
        private readonly IDoctorRepository _doctorRepository;
        public AssociateDoctorClinicCommandHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<DoctorClinicAssociation> Handle(AssociateDoctorClinicCommand request, CancellationToken cancellationToken)
        {

            var association = new DoctorClinicAssociation(request.DoctorId, request.ClinicId) ?? throw new Exception("Doctor is null");
            await _doctorRepository.AssociateDoctorClinic(association);
            return association;
        }
    }
}