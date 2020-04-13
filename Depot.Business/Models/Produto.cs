using System;
using System.Collections.Generic;


namespace Depot.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        public Guid EstoqueId { get; set; }

        public Guid GrupoId { get; set; }

        public string Nome { get; set; }


        public string Descricao { get; set; }


        public DateTime DataCadastro { get; set; }


        public bool Ativo { get; set; }

        /*EF Relations */
        public Fornecedor Fornecedor { get; set; }

        public Estoque Estoque { get; set; }

        public GrupoProduto GrupoProduto { get; set; }

        public IEnumerable<HistoricoProduto> HistoricoProduto { get; set; }
    }
}
