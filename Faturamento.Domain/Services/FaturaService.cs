using Barbearia.Domain.Entity;
using Barbearia.Domain.Interfaces.RepositoriesInterfaces;
using Barbearia.Domain.Interfaces.ServicesInterfaces;

namespace Barbearia.Domain.Services;
public class FaturaService(IFaturaRepository faturaRepository) : IFaturaService
{
    private readonly IFaturaRepository _faturaRepository = faturaRepository;

    public async Task<bool> Create(Fatura fatura, CancellationToken cancellationToken)
    {
        // TODO: Validar se produto existe
        return await _faturaRepository.Create(fatura, cancellationToken);
    }

    public Task<bool> Delete(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<List<Fatura>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Fatura?> GetById(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Fatura fatura, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
