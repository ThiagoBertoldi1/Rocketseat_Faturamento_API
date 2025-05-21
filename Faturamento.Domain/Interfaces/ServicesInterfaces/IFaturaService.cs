using Barbearia.Domain.Entity;

namespace Barbearia.Domain.Interfaces.ServicesInterfaces;

public interface IFaturaService
{
    Task<bool> Create(Fatura fatura, CancellationToken cancellationToken);
    Task<bool> Update(Fatura fatura, CancellationToken cancellationToken);
    Task<bool> Delete(long id, CancellationToken cancellationToken);
    Task<List<Fatura>> GetAll(CancellationToken cancellationToken);
    Task<Fatura?> GetById(long id, CancellationToken cancellationToken);
}