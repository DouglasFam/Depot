using Depot.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Depot.Data.Mappings
{
    class PerfilMapping : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomePerfil)
              .IsRequired()
              .HasColumnType("varchar(100)");

            builder.ToTable("Perfis");
        }
    }
}
