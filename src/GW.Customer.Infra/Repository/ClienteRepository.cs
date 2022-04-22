using GW.Customer.Domain;
using GW.Customer.Infra.Context;
using GW.Customer.Infra.Interfaces;

namespace GW.Customer.Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MeuDbContext context) : base(context)
        {
        }

    }
}