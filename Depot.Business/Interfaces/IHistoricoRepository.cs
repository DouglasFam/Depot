using Depot.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Depot.Business.Interfaces
{
   public interface IHistoricoRepository : IRepository<Historico>
    {
        Task<IEnumerable<Historico>> ObterHistoricoProduto(Guid ProdutoId);

        Task<IEnumerable<Historico>> ObterHistoricoColaborador(Guid ColaboradorId);

        Task<IEnumerable<Historico>> ObterHistoricoDepositador(Guid DepositanteId);

        Task<IEnumerable<Historico>> ObterHistoricoRetirante(Guid RetiranteId);

        Task<IEnumerable<Historico>> ObterHistoricoAutorizador(Guid AutorizadorId);
    }
}
