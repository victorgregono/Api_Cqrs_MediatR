using ApiCQRS.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiCQRS.Context
{
    public class FactoryContext : DbContext
    {
        public FactoryContext(DbContextOptions<FactoryContext> options) : base(options)
        {}
        public DbSet<Carga> Cargas { get; set; }
    }
}