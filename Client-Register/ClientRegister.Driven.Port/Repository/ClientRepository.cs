using AutoMapper;
using ClientRegister.Domain.Interfaces;
using ClientRegister.Domain.Model;
using ClientRegister.Driven.Adapters.Document;
using ClientRegister.Driven.Adapters.Interfaces;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Driven.Port.Repository
{
    public class ClientRepository : IClientRepository
    {
        public readonly IMapper _mapper;
        public readonly IClientRepositoryAdapter _clientRepositoryAdapter;

        public ClientRepository(IMapper mapper, IClientRepositoryAdapter clientRepositoryAdapter)
        {
            _mapper = mapper;
            _clientRepositoryAdapter = clientRepositoryAdapter;
        }

        public async Task<Guid> InsertOneAsync(Client client)
        {
            var request = _mapper.Map<ClientDocument>(client);
            return await _clientRepositoryAdapter.InsertOneAsync(request);
        }
    }
}
