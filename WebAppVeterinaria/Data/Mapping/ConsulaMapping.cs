using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Data.Mapping
{
    public class ConsulaMapping : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCadastro)
                .HasDefaultValueSql("getdate()");

            builder.Property(c => c.Descricao).HasColumnType("varchar(1000)");
            builder.Property(c => c.HistoricoClinicoAnimal).HasColumnType("varchar(1000)");

            builder.HasOne(P => P.Usuario)
                .WithMany()
                .HasForeignKey(p => p.UsuarioId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(a => a.Animal)
            //    .WithMany()
            //    .HasForeignKey(a => a.AnimalId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
