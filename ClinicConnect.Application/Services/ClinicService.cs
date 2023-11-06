using AutoMapper;
using ClinicConnect.Application.Commands.ClinicCommand;
using ClinicConnect.Application.DTOs;
using ClinicConnect.Application.Interfaces;
using MediatR;

namespace ClinicConnect.Application.Services
{
    public class ClinicService : IClinicService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ClinicService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<ClinicDTO> Add(ClinicDTO clinic)
        {
            var command = _mapper.Map<CreateClinicCommand>(clinic);
            await _mediator.Send(command);
            return clinic;
        }

        public Task<IEnumerable<ClinicDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}