using AutoMapper;
using ClientRegister.Domain.Interfaces;
using ClientRegister.Domain.Model;
using ClientRegister.Infrastructure.Data.Document;
using ClientRegister.Infrastructure.Data.Interfaces;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Infrastructure.Data.Repository
{
    public class ClientRepository: IClientRepository
    {
        private readonly string _databaseName = "tanjiroDB";
        private readonly string _collectionName = "clients";
        private readonly IMongoCollection<ClientDocument> _collection;

        public ClientRepository(string connectionString)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(_databaseName);
            _collection = database.GetCollection<ClientDocument>(_collectionName);
        }
        public virtual async Task<Guid> InsertOneAsync(ClientDocument document)
        {
            await _collection.InsertOneAsync(document);
            return document.Id;
        }
    }
}
