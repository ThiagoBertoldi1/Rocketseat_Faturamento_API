using Barbearia.Data.Repository;
using Barbearia.Domain.Interfaces.RepositoriesInterfaces;
using Barbearia.Domain.Interfaces.ServicesInterfaces;
using Barbearia.Domain.Services;

namespace Barbearia.API.DI;

public static class DIServices
{
    public static void ServicesDI(this IServiceCollection services)
        => services.AddTransient<IFaturaService, FaturaService>();

    public static void RepositoriesDI(this IServiceCollection services)
        => services.AddTransient<IFaturaRepository, FaturaRepository>();
}
