using System;
using System.Collections.Generic;

namespace Depot.Business.Models
{
    public class Historico : Entity
    {
        public TipoMovimento TipoMovimento { get; set; }

        public DateTime DataMovimento { get; set; }

        public DateTime HoraMovimento { get; set; }

        public Guid ColaboradorId { get; set; }

        public Guid AutorizadorId { get; set; }

        public Guid RetiranteId { get; set; }

        public Guid DepositanteId { get; set; }


        /* EF Relations */
        public IEnumerable<HistoricoProduto> HistoricoProduto { get; set; }

        public Colaborador Colaborador { get; set; }
    }
}
