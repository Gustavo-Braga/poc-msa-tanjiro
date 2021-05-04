using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ClientRegister.Driven.Adapters.Document
{
    public class ClientDocument
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
    }
}
