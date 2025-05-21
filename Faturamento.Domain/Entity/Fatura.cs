using Barbearia.Domain.Enums;

namespace Barbearia.Domain.Entity;

public class Fatura
{
    public long Id { get; set; }
    public long IdProduto { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime DtInclusao { get; set; } = DateTime.Now;
    public MetodoPagamento MetodoPagamento { get; set; }
}