using ClinicConnect.Domain.Entites;
using MediatR;

namespace ClinicConnect.Application.Queries
{
    public class GetAllDoctorsQuery : IRequest<IEnumerable<Doctor>>
    {

    }
}