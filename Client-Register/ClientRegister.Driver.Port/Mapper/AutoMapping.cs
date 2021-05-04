using AutoMapper;
using ClientRegister.Domain.Model;
using ClientRegister.Driver.Port.ClientRequest;

namespace ClientRegister.Driver.Port.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Client, AddClientRequest>().ReverseMap();
        }
    }
}
