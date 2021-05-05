using ClientRegister.Domain.Model;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<Guid> InsertOneAsync(Client client);
    }
}
