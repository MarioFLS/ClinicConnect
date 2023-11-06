using ClinicConnect.Application.Commands.ClinicCommand;
using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using MediatR;

namespace ClinicConnect.Application.Handlers.ClinicHandlers
{
    public class CreateClinicCommandhandler : IRequestHandler<CreateClinicCommand, Clinic>
    {

        private readonly IClinicRepository _clinicRepository;

        public CreateClinicCommandhandler(IClinicRepository clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        public async Task<Clinic> Handle(CreateClinicCommand request, CancellationToken cancellationToken)
        {
            var clinic = new Clinic(request.Name, request.Address, request.Email, request.Phone) ?? throw new Exception("Clinic is null");

            await _clinicRepository.CreateAsync(clinic);
            return clinic;
        }
    }
}