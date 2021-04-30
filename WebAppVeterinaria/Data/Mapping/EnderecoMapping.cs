using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro).HasColumnType("varchar(250)");
            builder.Property(e => e.Numero).HasColumnType("varchar(50)");
            builder.Property(e => e.Estado).HasColumnType("varchar(20)");
            builder.Property(e => e.Cidade).HasColumnType("varchar(100)");
            builder.Property(e => e.Complemento).HasColumnType("varchar(100)");
            builder.Property(e => e.Cep).HasColumnType("varchar(20)");
            builder.Property(e => e.Bairro).HasColumnType("varchar(100)");

            builder.ToTable("Enderecos");
        }
    }
}
