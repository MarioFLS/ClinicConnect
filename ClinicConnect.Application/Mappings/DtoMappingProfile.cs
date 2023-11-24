using AutoMapper;
using ClinicConnect.Application.DTOs;
using ClinicConnect.Domain.Entites;

namespace ClinicConnect.Application.Mappings
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Doctor, DoctorDTO>();
            CreateMap<Clinic, ClinicDTO>();
            CreateMap<DoctorClinicAssociation, DoctorClinicAssociationDTO>();
        }
    }
}