using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Data.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.NomeCompleto).HasColumnType("varchar(100)");
            builder.Property(c => c.Rg).HasColumnType("varchar(20)");
            builder.Property(c => c.Cpf).HasColumnType("varchar(20)");
            builder.Property(c => c.Telefone).HasColumnType("varchar(20)");
            builder.Property(c => c.Celular).HasColumnType("varchar(20)");

            // 1 : 1 => Cliente : Endereco
            builder.HasOne(c => c.Endereco)
                .WithOne(e => e.Cliente);

            builder.ToTable("Clientes");

        }
    }
}
