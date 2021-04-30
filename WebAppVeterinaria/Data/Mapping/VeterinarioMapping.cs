using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Data.Mapping
{
    public class VeterinarioMapping : IEntityTypeConfiguration<Veterinario>
    {
        public void Configure(EntityTypeBuilder<Veterinario> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.NomeCompleto).HasColumnType("varchar(100)");
            builder.Property(v => v.CodigoCRMV).HasColumnType("varchar(50)");
            builder.Property(v => v.Cpf).HasColumnType("varchar(20)");
            builder.Property(v => v.Rg).HasColumnType("varchar(50)");

            // 1 : 1 => Veterinario : Endereco
            builder.HasOne(v => v.Endereco)
                .WithOne(e => e.Veterinario);

            builder.ToTable("Veterinarios");
        }
    }
}
