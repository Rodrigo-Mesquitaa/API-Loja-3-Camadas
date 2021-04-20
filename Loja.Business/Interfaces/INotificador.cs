using System.Collections.Generic;
using Loja.Business.Notificacoes;

namespace Loja.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}