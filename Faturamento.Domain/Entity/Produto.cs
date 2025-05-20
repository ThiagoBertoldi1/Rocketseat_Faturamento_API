namespace Faturamento.Domain.Entity;

public class Produto
{
    public long Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
