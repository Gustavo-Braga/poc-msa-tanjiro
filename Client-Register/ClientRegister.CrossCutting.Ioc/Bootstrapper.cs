using ClientRegister.CrossCutting.Configuration;
using ClientRegister.Domain.Interfaces;
using ClientRegister.Domain.Services;
using ClientRegister.Driven.Adapters.Interfaces;
using ClientRegister.Driven.Adapters.Repository;
using ClientRegister.Driven.Port.Repository;
using ClientRegister.Driver.Port.ClientRequest;
using ClientRegister.Driver.Port.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ClientRegister.CrossCutting.Ioc
{
    public static class Bootstrapper
    {
        public static void Inject(IServiceCollection service)
        {
            service.AddMvc();
            Driver(service);
            Center(service);
            Driven(service);
        }

        private static void Driver(IServiceCollection service)
        {
            service.AddAutoMapper(typeof(Driver.Port.Mapper.AutoMapping));
            service.AddScoped<IClientCommandHandler, ClientCommandHandler>();
        }

        private static void Center(IServiceCollection service)
        {
            service.AddScoped<IClientRepository, ClientRepository>();
            service.AddScoped<IClientService, ClientService>();
        }

        private static void Driven(IServiceCollection service)
        {
            service.AddAutoMapper(typeof(Driven.Port.Mapper.AutoMapping));
            service.AddScoped<IClientRepositoryAdapter, ClientRepositoryAdapter>(x=> new ClientRepositoryAdapter(AppSettings.GetValue("ConnectionString")));
        }
    }
}
