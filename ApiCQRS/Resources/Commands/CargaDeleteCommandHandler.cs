using ApiCQRS.Context;
using ApiCQRS.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiCQRS.Resources.Commands
{
    public class CargaDeleteCommandHandler : IRequestHandler<CargaDeleteCommand, Carga>
    {
        private readonly FactoryContext _context;

        public CargaDeleteCommandHandler(FactoryContext context)
        {
            _context = context;
        }
        public async Task<Carga> Handle(CargaDeleteCommand request, CancellationToken cancellationToken)
        {
            var carga = await _context.Cargas.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
            _context.Remove(carga);
            await _context.SaveChangesAsync();
            return carga;
        }
    }
}
