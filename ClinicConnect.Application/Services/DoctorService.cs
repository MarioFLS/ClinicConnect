using AutoMapper;
using ClinicConnect.Application.Commands;
using ClinicConnect.Application.DTOs;
using ClinicConnect.Domain.Entites;
using MediatR;

namespace ClinicConnect.Application.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public DoctorService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<DoctorDTO> Add(DoctorDTO doctor)
        {
            var command = _mapper.Map<CreateDoctorCommand>(doctor);
            await _mediator.Send(command);
            return doctor;
        }

        public Task<IEnumerable<DoctorDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}