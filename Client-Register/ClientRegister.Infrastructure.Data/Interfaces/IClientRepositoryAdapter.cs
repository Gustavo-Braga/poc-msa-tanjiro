using ClientRegister.Driven.Adapters.Document;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Driven.Adapters.Interfaces
{
    public interface IClientRepositoryAdapter
    {
        Task<Guid> InsertOneAsync(ClientDocument document);
    }
}
