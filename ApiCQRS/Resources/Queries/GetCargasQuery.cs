using ApiCQRS.Model;
using MediatR;

namespace ApiCQRS.Resources.Queries
{
    public class GetCargasQuery : IRequest<IEnumerable<Carga>>
    {
    }
}