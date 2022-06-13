using ApiCQRS.Context;
using ApiCQRS.Model;
using MediatR;

namespace ApiCQRS.Resources.Commands
{
    public class CargaCreateCommandHandler : IRequestHandler<CargaCreateCommand, Carga>
    {
        private readonly FactoryContext _context;

        public CargaCreateCommandHandler(FactoryContext context)
        {
            _context = context;
        }

        public async Task<Carga> Handle(CargaCreateCommand request, CancellationToken cancellationToken)
        {
            var carga = new Carga();

            carga.Nome = request.Nome;
            carga.Status = request.Status;
            carga.Trasporte = request.Trasporte;

            _context.Cargas.Add(carga);
            await _context.SaveChangesAsync(cancellationToken);
            return carga;
        }
    }
}