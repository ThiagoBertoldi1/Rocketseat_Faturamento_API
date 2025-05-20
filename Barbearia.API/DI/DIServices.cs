using Faturamento.Data.Repository;
using Faturamento.Domain.Interfaces.RepositoriesInterfaces;
using Faturamento.Domain.Interfaces.ServicesInterfaces;
using Faturamento.Domain.Services;

namespace Barbearia.API.DI;

public static class DIServices
{
    public static void ServicesDI(this IServiceCollection services)
        => services.AddTransient<IFaturaService, FaturaService>();

    public static void RepositoriesDI(this IServiceCollection services)
        => services.AddTransient<IFaturaRepository, FaturaRepository>();
}
