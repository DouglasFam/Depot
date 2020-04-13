using Depot.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Depot.Data.Mappings
{
    public class HistoricoProdutoMapping : IEntityTypeConfiguration<HistoricoProduto>
    {
        public void Configure(EntityTypeBuilder<HistoricoProduto> builder)
        {
            builder.HasOne<Historico>(hp => hp.Historico)
                .WithMany(h => h.HistoricoProduto)
                .HasForeignKey(hp => hp.HistoricoId);

            builder.HasOne<Produto>(hp => hp.Produto)
                .WithMany(p => p.HistoricoProduto)
                .HasForeignKey(hp => hp.ProdutoId);

        //    builder.HasKey(hp => new { hp.HistoricoId, hp.ProdutoId });
        //    builder.HasOne(h => h.Historico).WithMany(h => h.HistoricoProduto).HasForeignKey(h => h.HistoricoId);
        //    builder.HasOne(p => p.Produto).WithMany(p => p.HistoricoProduto).HasForeignKey(p => p.ProdutoId);

            builder.ToTable("HistoricoProdutos");


        }
    }
}

