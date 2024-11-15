using DesafioFinal.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioFinal.Api.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Nome).HasColumnName("Nome").HasColumnType("varchar(200)");
            builder.Property(p => p.Email).HasColumnName("Email").HasColumnType("varchar(150)");
            builder.ToTable("Clientes");
        }
    }
}
