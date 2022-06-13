using ApiCQRS.Context;
using ApiCQRS.Model;
using MediatR;

namespace ApiCQRS.Resources.Commands
{
    public class CargaUpdateCommandHandler : IRequestHandler<CargaUpdateCommand, Carga>
    {
        private readonly FactoryContext _context;

        public CargaUpdateCommandHandler(FactoryContext context)
        {
            _context = context;
        }

        public async Task<Carga> Handle(CargaUpdateCommand request, CancellationToken cancellationToken)
        {
            var carga = _context.Cargas.FirstOrDefault(a => a.Id == request.Id);
            if (carga is null)
            {
                return default;
            }

            carga.Id = request.Id;
            carga.Nome = request.Nome;
            carga.Status = request.Status;
            carga.Trasporte = request.Trasporte;
            await _context.SaveChangesAsync();
            return carga;
        }
    }
}