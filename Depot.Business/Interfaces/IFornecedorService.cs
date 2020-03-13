

using Depot.Business.Models;
using Depot.Business.Services;
using System;
using System.Threading.Tasks;

namespace Depot.Business.Interfaces
{
    public interface IFornecedorService
    {
        Task Adicionar(Fornecedor fornecedor);

        Task Atualizar(Fornecedor fornecedor);

        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}
