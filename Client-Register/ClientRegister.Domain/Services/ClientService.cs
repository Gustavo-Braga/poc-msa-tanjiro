using ClientRegister.Domain.Interfaces;
using ClientRegister.Domain.Model;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Domain.Services
{
    public class ClientService: IClientService
    {
        public readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Guid> Create(Client client)
        {
            try
            {
                return await _clientRepository.InsertOneAsync(client);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
