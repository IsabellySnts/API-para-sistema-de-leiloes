using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RockeseatLeilao.API.Entity;
using RockeseatLeilao.API.UseCases.Leiloes.GetCurrent;

namespace RockeseatLeilao.API.Controllers
{
    [Route("api/[controller]")] // url padrao
    [ApiController] // especificando que essa classe é um controller
    public class LeilaoController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentLeilao()
        {
            var userCase = new GetCurrentLeilaoUseCase();

            var result = userCase.ExecuteCase();

            if (result is null)
                return NoContent();

            return Ok(result);
        }
    }
}
