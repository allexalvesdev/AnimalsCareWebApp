using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Data.Mapping
{
    public class AnimalMapping : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasColumnType("varchar(50)");
            builder.Property(a => a.Raca).HasColumnType("varchar(50)");
            builder.Property(a => a.Idade).HasColumnType("varchar(50)");
            builder.Property(a => a.Peso).HasColumnType("varchar(50)");
            builder.Property(a => a.Observacao).HasColumnType("varchar(250)");

            builder.HasOne(P => P.Usuario)
                .WithMany()
                .HasForeignKey(p => p.UsuarioId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Animais");
        }
    }
}
