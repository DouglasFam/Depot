using Depot.Business.Interfaces;
using Depot.Business.Models;
using Depot.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Depot.Data.Repository
{
    public class HistoricoRepository : Repository<Historico>, IHistoricoRepository
    {
        public HistoricoRepository(MeuDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Historico>> ObterHistoricoColaborador(Guid ColaboradorId)
        {
            return await Buscar(h => h.ColaboradorId == ColaboradorId);
        }

        public async Task<IEnumerable<Historico>> ObterHistoricoDepositador(Guid DepositanteId)
        {
            return await Buscar(h => h.ColaboradorId == DepositanteId);
        }

        public async Task<IEnumerable<Historico>> ObterHistoricoAutorizador(Guid AutorizadorId)
        {
            return await Buscar(h => h.ColaboradorId == AutorizadorId);
        }

        public async Task<IEnumerable<Historico>> ObterHistoricoProduto(Guid ProdutoId)
        {
            throw new NotImplementedException();

          

            //var result = from cp in cursosProfessores from p in professores where curso.ID == cp.CursoID && p.Key == cp.ProfessorID select p.Value;
            //return result.ToList();
        }

        public Task<IEnumerable<Historico>> ObterHistoricoRetirante(Guid RetiranteId)
        {
            throw new NotImplementedException();
        }
    }
}
