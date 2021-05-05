using ClientRegister.Domain.Model;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Domain.Interfaces
{
    public interface IClientService
    {
        Task<Guid> Create(Client client);
    }
}
