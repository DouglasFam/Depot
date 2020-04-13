using Microsoft.EntityFrameworkCore;
using Depot.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Depot.Data.Mappings
{
    public class EstoqueMapping : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.NomeEstoque)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Regiao)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.HasMany(e => e.Produtos)
                .WithOne(p => p.Estoque)
                .HasForeignKey(p => p.EstoqueId);

            builder.ToTable("Estoques");

        }
    }
}
