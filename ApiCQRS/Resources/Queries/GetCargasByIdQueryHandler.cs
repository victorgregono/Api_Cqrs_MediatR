using ApiCQRS.Context;
using ApiCQRS.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiCQRS.Resources.Queries
{
    public class GetCargasByIdQueryHandler : IRequestHandler<GetCargasByIdQuery, Carga>
    {
        private readonly FactoryContext _context;

        public GetCargasByIdQueryHandler(FactoryContext context)
          => _context = context;

        public async Task<Carga> Handle(GetCargasByIdQuery request, CancellationToken cancellationToken)
        => await _context.Cargas.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
    }
}