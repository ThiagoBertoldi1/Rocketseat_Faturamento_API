using Faturamento.Domain.Entity;
using Faturamento.Domain.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Barbearia.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FaturamentoController(IFaturaService service) : ControllerBase
{
    private readonly IFaturaService _service = service;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Fatura fatura, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _service.Create(fatura, cancellationToken);

            return result ? Created() : BadRequest();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return StatusCode(500, "Occoreu um erro interno do servidor");
        }
    }
}