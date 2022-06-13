using ApiCQRS.Model;
using MediatR;

namespace ApiCQRS.Resources.Queries
{
    public class GetCargasByIdQuery : IRequest<Carga>
    {
        public int Id { get; set; }
    }
}