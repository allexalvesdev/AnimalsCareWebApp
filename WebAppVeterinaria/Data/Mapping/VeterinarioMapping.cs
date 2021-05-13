using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.Property(e => e.Logradouro).HasColumnType("varchar(250)");
            builder.Property(e => e.Numero).HasColumnType("varchar(50)");
            builder.Property(e => e.Estado).HasColumnType("varchar(20)");
            builder.Property(e => e.Cidade).HasColumnType("varchar(100)");
            builder.Property(e => e.Complemento).HasColumnType("varchar(100)");
            builder.Property(e => e.Cep).HasColumnType("varchar(20)");
            builder.Property(e => e.Bairro).HasColumnType("varchar(100)");

            builder.HasOne(P => P.Usuario)
                    .WithMany()
                    .HasForeignKey(p => p.UsuarioId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);


            builder.ToTable("Veterinarios");
        }
    }
}
