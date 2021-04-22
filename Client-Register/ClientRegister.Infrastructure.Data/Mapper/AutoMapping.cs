using AutoMapper;
using ClientRegister.Domain.Model;
using ClientRegister.Infrastructure.Data.Document;

namespace ClientRegister.Infrastructure.Data.Mapper
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Client, ClientDocument>().ReverseMap();
        }
    }
}
