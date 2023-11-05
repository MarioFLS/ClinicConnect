using AutoMapper;
using ClinicConnect.Application.Commands;
using ClinicConnect.Application.DTOs;

namespace ClinicConnect.Application.Mappings
{
    public class CommandMappingProfile : Profile
    {
        public CommandMappingProfile()
        {
            CreateMap<DoctorDTO, CreateDoctorCommand>();
        }
    }
}