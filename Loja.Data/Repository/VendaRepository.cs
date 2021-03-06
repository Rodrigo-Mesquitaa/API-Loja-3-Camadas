using Loja.Business.Interfaces;
using Loja.Business.Models;
using Loja.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Data.Repository
{
    public class VendaRepository : Repository<Venda>, IVendaRepository
    {
        public VendaRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<Venda>> ObterVendasCliente(Guid clienteId)
        {
            return await Buscar(v => v.ClienteId == clienteId);

        }

        public async Task<Venda> ObterCarrinhoCliente(Guid id)
        {
            return await Db.Vendas.AsNoTracking()
                .Include(c => c.Cliente)               
                .FirstOrDefaultAsync(i => i.Id == id);
        }
    }
    
}
