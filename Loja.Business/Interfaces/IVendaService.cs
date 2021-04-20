using Loja.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loja.Business.Interfaces
{
    public interface IVendaService : IDisposable
    {
        Task Adicionar(Venda venda);
        Task Atualizar(Venda venda);
        Task Remover(Guid id);        
    }
}
