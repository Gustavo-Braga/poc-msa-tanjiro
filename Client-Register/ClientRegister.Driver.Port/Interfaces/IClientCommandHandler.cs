using ClientRegister.Driver.Port.ClientRequest;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Driver.Port.Interfaces
{
    public interface IClientCommandHandler
    {
        Task<Guid> Create(AddClientRequest client);
    }
}
