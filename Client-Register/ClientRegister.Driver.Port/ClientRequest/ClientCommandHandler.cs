using AutoMapper;
using ClientRegister.Domain.Interfaces;
using ClientRegister.Domain.Model;
using ClientRegister.Driver.Port.Interfaces;
using System;
using System.Threading.Tasks;

namespace ClientRegister.Driver.Port.ClientRequest
{
    public class ClientCommandHandler: IClientCommandHandler
    {
        public readonly IClientService _clientService;
        public readonly IMapper _mapper;
        public ClientCommandHandler(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<Guid> Create(AddClientRequest client)
        {
            try
            {
                var request = _mapper.Map<Client>(client);
                return await _clientService.Create(request);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
