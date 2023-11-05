using AutoMapper;
using ClinicConnect.Application.DTOs;
using ClinicConnect.Domain.Entites;

namespace ClinicConnect.Application.Mappings
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<DoctorDTO, Doctor>();
        }
    }
}