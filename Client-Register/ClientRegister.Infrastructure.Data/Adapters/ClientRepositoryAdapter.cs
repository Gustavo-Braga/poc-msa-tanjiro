using AutoMapper;
using ClientRegister.Domain.Interfaces;
using ClientRegister.Domain.Model;
using ClientRegister.Infrastructure.Data.Document;
using ClientRegister.Infrastructure.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Infrastructure.Data.Adapters
{
    public class ClientRepositoryAdapter : IClientRepositoryAdapter
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public ClientRepositoryAdapter(IMapper mapper, IClientRepository clientRepository)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
        }

        public async Task<Guid> InsertOneAsync(Client client)
        {
            var document = _mapper.Map<ClientDocument>(client);
            return await _clientRepository.InsertOneAsync(document);
        }
    }
}
