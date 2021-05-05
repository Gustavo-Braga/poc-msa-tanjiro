using ClientRegister.Driven.Adapters.Document;
using ClientRegister.Driven.Adapters.Interfaces;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Driven.Adapters.Repository
{
    public class ClientRepositoryAdapter : IClientRepositoryAdapter
    {
        private readonly string _databaseName = "tanjiroDB";
        private readonly string _collectionName = "clients";
        private readonly IMongoCollection<ClientDocument> _collection;

        public ClientRepositoryAdapter(string connectionString)
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
