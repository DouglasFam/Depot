using Depot.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Depot.Business.Interfaces
{
    interface IEstoqueRepository : IRepository<Estoque>
    {
        Task<IEnumerable<Estoque>> ObterEstoquePorRegiao(string regiao);
    }
}
