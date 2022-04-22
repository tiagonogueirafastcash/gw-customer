using GW.Customer.Application.Interfaces;
using GW.Customer.Domain;
using GW.Customer.Domain.Models.Validations;
using GW.Customer.Infra.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GW.Customer.Application.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository,
                                 INotificador notificador) : base(notificador)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> Adicionar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidation(), cliente)) return false;

            if (_clienteRepository.Buscar(f => f.Cpf == cliente.Cpf).Result.Any())
            {
                Notificar("Já existe um cliente com este documento informado.");
                return false;
            }

            await _clienteRepository.Adicionar(cliente);
            return true;
        }

        public async Task<bool> Atualizar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidation(), cliente)) return false;

            if (_clienteRepository.Buscar(f => f.Cpf == cliente.Cpf && f.Id != cliente.Id).Result.Any())
            {
                Notificar("Já existe um cliente com este documento infomado.");
                return false;
            }

            await _clienteRepository.Atualizar(cliente);
            return true;
        }

        public async Task<bool> Remover(Guid id)
        {
            await _clienteRepository.Remover(id);
            return true;
        }

        public void Dispose()
        {
            _clienteRepository?.Dispose();
        }
    }
}