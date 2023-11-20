using ClinicConnect.Domain.Entites;
using MediatR;

namespace ClinicConnect.Application.Queries
{
    public class GetAllClinicsQuery : IRequest<IEnumerable<Clinic>>
    {
    }
}