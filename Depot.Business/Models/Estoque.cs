using System;
using System.Collections.Generic;
using System.Text;

namespace Depot.Business.Models
{
    public class Estoque : Entity
    {
        public Guid produtoId { get; set; }
        public string NomeEstoque { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Regiao { get; set; }

        public bool Ativo { get; set; }

        /* EF RELATIONS */
        public IEnumerable<Produto> Produtos { get; set; }



    }
}
