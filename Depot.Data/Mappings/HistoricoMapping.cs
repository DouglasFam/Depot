using Depot.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Depot.Data.Mappings
{
    public class HistoricoMapping : IEntityTypeConfiguration<Historico>
    {
       public void Configure(EntityTypeBuilder<Historico> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.DataMovimento)
                .IsRequired()              
                .HasColumnType("datetime");


           // 1 : N => Colaborador : Historico
            //builder.HasMany(c => c.Colaborador)
            //    .WithOne(h => h.Colaborador)
            //    .HasForeignKey(h => h.ColaboradorId);

            builder.ToTable("Historicos");

        }
    }
}
