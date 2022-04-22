using GW.Customer.Domain;
using System;
using System.Threading.Tasks;

namespace GW.Customer.Application.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Task<bool> Adicionar(Cliente cliente);
        Task<bool> Atualizar(Cliente cliente);
        Task<bool> Remover(Guid id);

    }
}