using Dapper;
using Faturamento.Domain.Entity;
using Faturamento.Domain.Interfaces.RepositoriesInterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Faturamento.Data.Repository;

public class FaturaRepository(IConfiguration configuration) : IFaturaRepository
{
    private readonly string _connString = configuration.GetConnectionString("DB")!;

    public async Task<List<Fatura>> GetAll(CancellationToken cancellationToken)
    {
        var sql = "SELECT * FROM Fatura";

        using var connection = new SqlConnection(_connString);
        connection.Open();
        return [.. await connection.QueryAsync<Fatura>(sql)];
    }

    public async Task<Fatura?> GetById(long id, CancellationToken cancellationToken)
    {
        var sql = "SELECT * FROM Fatura WHERE Id = @Id";

        using var connection = new SqlConnection(_connString);
        connection.Open();
        return await connection.QueryFirstOrDefaultAsync<Fatura>(sql, new { Id = id });
    }

    public async Task<bool> Create(Fatura fatura, CancellationToken cancellationToken)
    {
        var sql = @"
            INSERT INTO Fatura (IdProduto, Descricao, DtInclusao, MetodoPagamento)
            VALUES (@IdProduto, @Descricao, @DtInclusao, @MetodoPagamento);";

        using var connection = new SqlConnection(_connString);
        connection.Open();
        return (await connection.ExecuteAsync(sql, fatura)) > 0;
    }

    public async Task<bool> Update(Fatura fatura, CancellationToken cancellationToken)
    {
        var sql = @"
            UPDATE Fatura
            SET IdProduto = @IdProduto,
                Descricao = @Descricao,
                DtInclusao = @DtInclusao,
                MetodoPagamento = @MetodoPagamento
            WHERE Id = @Id";

        using var connection = new SqlConnection(_connString);
        connection.Open();
        return (await connection.ExecuteAsync(sql, fatura)) > 0;
    }

    public async Task<bool> Delete(long id, CancellationToken cancellationToken)
    {
        var sql = "DELETE FROM Fatura WHERE Id = @Id";

        using var connection = new SqlConnection(_connString);
        connection.Open();
        return (await connection.ExecuteAsync(sql, new { Id = id })) > 0;
    }
}
