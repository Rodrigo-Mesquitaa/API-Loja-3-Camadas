using System;
using System.Collections.Generic;
using Loja.Business.Enums;

namespace Loja.Business.Models
{
    public class Venda : Entity
    {
        public DateTime DataVenda { get; set; }
        public TipoVenda TipoVenda { get; set; }
        public StatusVenda StatusVenda { get; set; }
        public string Observacoes { get; set; }

        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<VendaItem> VendaItens { get; set; }
    }
}
