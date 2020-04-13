using Depot.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Depot.Data.Context
{
    
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) { }      

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<GrupoProduto> GrupoProdutos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Historico> Historicos { get; set; }

        public DbSet<HistoricoProduto> HistoricoProduto { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

        public DbSet<Perfil> Perfil { get; set; }

        public DbSet<Estoque> Estoques { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seta variavel varchar para não entrar como Max no banco
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(100)";

            //pega as entidades mapeadas no Db Context e registra
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            //Desabilita Cascade delete
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

      
    }
}
