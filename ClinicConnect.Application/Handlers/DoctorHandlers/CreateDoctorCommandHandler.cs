using ClinicConnect.Application.Commands;
using ClinicConnect.Domain.Entites;
using ClinicConnect.Domain.Interfaces.Repository;
using MediatR;

namespace ClinicConnect.Application.Handlers.DoctorHandlers
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, Doctor>
    {
        private readonly IDoctorRepository _doctorRepository;
        public CreateDoctorCommandHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<Doctor> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            var doctor = new Doctor(request.Name, request.Email, request.Phone, request.Specialization) ?? throw new Exception("Doctor is null");
            await _doctorRepository.CreateAsync(doctor);
            return doctor;
        }
    }
}