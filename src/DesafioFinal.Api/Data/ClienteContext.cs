using DesafioFinal.Api.Data.Maps;
using DesafioFinal.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinal.Api.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
        }
    }
}
