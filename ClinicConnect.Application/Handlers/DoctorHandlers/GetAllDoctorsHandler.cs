using ClinicConnect.Application.Queries;
using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using MediatR;

namespace ClinicConnect.Application.Handlers
{
    public class GetAllDoctorsHandler : IRequestHandler<GetAllDoctorsQuery, IEnumerable<Doctor>>
    {
        private readonly IDoctorRepository _doctorRepository;
        public GetAllDoctorsHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<Doctor>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
        {
            var doctors = await _doctorRepository.GetAllAsync();
            return doctors;
        }
    }
}