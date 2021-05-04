using AutoMapper;
using ClientRegister.Domain.Model;
using ClientRegister.Driven.Adapters.Document;

namespace ClientRegister.Driven.Port.Mapper
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Client, ClientDocument>().ReverseMap();
        }
    }
}
