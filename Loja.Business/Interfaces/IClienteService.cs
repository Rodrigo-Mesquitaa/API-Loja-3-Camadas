using Loja.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loja.Business.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Task Adicionar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task Remover(Guid id);
        Task AtualizarEndereco(Endereco endereco);

    }
}
