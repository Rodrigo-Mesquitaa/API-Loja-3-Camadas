using Loja.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loja.Business.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> ObterClienteEndereco(Guid id);
    }
}
