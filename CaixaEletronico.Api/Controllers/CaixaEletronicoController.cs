using CaixaEletronico.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CaixaEletronico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaixaEletronicoController : ControllerBase
    {
        private readonly ICaixa _caixa;

        public CaixaEletronicoController(ICaixa caixa)
        {
            _caixa = caixa;
        }

        [HttpPost("saque/{valor}")]
        public ActionResult Saque(int valor)
        {
            if (!_caixa.ValidaCedulasDisponiveis(valor))
                return BadRequest("Valor não válido para saque. Notas Disponíveis: 100, 50, 20 e 10 ");

            return Ok($"Receba seu saque: { string.Join(',', _caixa.Saque(valor)) }");
                   
        }
    }
}
