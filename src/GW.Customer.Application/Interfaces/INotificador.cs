using GW.Customer.Application.Notificacoes;
using System.Collections.Generic;

namespace GW.Customer.Application.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}