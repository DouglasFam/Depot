using System;
using System.Collections.Generic;
using System.Text;

namespace Depot.Business.Models
{
    public class HistoricoProduto : Entity
    {
        public Guid ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public Guid HistoricoId { get; set; }

        public Historico Historico { get; set; }

       

    }
}
