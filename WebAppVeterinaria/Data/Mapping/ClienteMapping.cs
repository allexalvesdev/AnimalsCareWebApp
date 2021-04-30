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
            builder.Property(e => e.Logradouro).HasColumnType("varchar(250)");
            builder.Property(e => e.Numero).HasColumnType("varchar(50)");
            builder.Property(e => e.Estado).HasColumnType("varchar(20)");
            builder.Property(e => e.Cidade).HasColumnType("varchar(100)");
            builder.Property(e => e.Complemento).HasColumnType("varchar(100)");
            builder.Property(e => e.Cep).HasColumnType("varchar(20)");
            builder.Property(e => e.Bairro).HasColumnType("varchar(100)");

            builder.ToTable("Clientes");

        }
    }
}
