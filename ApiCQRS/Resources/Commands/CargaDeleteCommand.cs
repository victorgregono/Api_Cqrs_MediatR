using ApiCQRS.Model;
using MediatR;

namespace ApiCQRS.Resources.Commands
{
    public class CargaDeleteCommand : IRequest<Carga>
    {
        public int Id { get; set; }
    }
}
