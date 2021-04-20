using System;
using System.Threading.Tasks;
using Loja.Business.Models;

namespace Loja.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
        Task<Endereco> ObterEnderecoPorCliente(Guid clienteId);
    }
}