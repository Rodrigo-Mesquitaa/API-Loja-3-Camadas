using System;
using System.Threading.Tasks;
using Loja.Business.Models;

namespace Loja.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}