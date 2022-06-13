using ApiCQRS.Context;
using ApiCQRS.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApiCQRS.Resources.Queries
{
    public class GetCargasQueryHandler : IRequestHandler<GetCargasQuery, IEnumerable<Carga>>
    {
        private readonly FactoryContext _context;

        public GetCargasQueryHandler(FactoryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Carga>> Handle(GetCargasQuery request, CancellationToken cancellationToken)

            => await _context.Cargas.ToListAsync(cancellationToken: cancellationToken);
    }
}