using Loja.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Business.Interfaces
{
    public interface IVendaItemService : IDisposable
    {
        Task Adicionar(VendaItem vendaItem);
        Task Atualizar(VendaItem vendaItem);
        Task Remover(Guid id);
    }
}
