using System;

namespace ClientRegister.Domain.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
    }
}
