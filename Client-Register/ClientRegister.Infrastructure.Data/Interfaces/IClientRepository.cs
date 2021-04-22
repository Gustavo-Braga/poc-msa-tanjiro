using ClientRegister.Infrastructure.Data.Document;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Infrastructure.Data.Interfaces
{
    public interface IClientRepository
    {
        Task<Guid> InsertOneAsync(ClientDocument document);
    }
}
