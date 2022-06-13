using ApiCQRS.Model;
using MediatR;

namespace ApiCQRS.Resources.Commands
{
    public class CargaUpdateCommand : IRequest<Carga>
    {
        public long Id { get; set; }
        public string Nome { get; set; }      
        public char Status { get; set; }      
        public string Trasporte { get; set; }
    }
}
