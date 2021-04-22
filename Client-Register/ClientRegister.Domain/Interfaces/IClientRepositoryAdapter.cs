using ClientRegister.Domain.Model;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Domain.Interfaces
{
    public interface IClientRepositoryAdapter
    {
        Task<Guid> InsertOneAsync(Client document);
    }
}
