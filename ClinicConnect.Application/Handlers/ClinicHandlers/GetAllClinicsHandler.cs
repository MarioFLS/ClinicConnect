using ClinicConnect.Application.Queries;
using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using MediatR;

namespace ClinicConnect.Application.Handlers.ClinicHandlers
{
    public class GetAllClinicsHandler : IRequestHandler<GetAllClinicsQuery, IEnumerable<Clinic>>
    {
        private readonly IClinicRepository _clinicRepository;

        public GetAllClinicsHandler(IClinicRepository clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        public async Task<IEnumerable<Clinic>> Handle(GetAllClinicsQuery request, CancellationToken cancellationToken)
        {
            var clinics = await _clinicRepository.GetAllAsync();
            return clinics;
        }
    }
}