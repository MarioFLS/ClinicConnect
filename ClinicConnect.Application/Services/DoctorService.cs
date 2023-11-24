using AutoMapper;
using ClinicConnect.Application.Commands;
using ClinicConnect.Application.Commands.DoctorCommand;
using ClinicConnect.Application.DTOs;
using ClinicConnect.Application.Queries;
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

        public async Task<DoctorClinicAssociation> AssociateDoctorClinic(DoctorClinicAssociationDTO association)
        {
            var command = _mapper.Map<AssociateDoctorClinicCommand>(association);
            return await _mediator.Send(command);
        }

        public async Task<IEnumerable<DoctorDTO>> GetAll()
        {
            var query = new GetAllDoctorsQuery();
            var result = await _mediator.Send(query);
            return _mapper.Map<IEnumerable<DoctorDTO>>(result);
        }
    }
}