using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase {
        
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora() {
            var obj = new { 
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Aprensentar/{nome}")]
        public IActionResult Apresentar(string nome) {
            var mensagem = $"Olá {nome}, seja bem vindo!";

            return Ok(new {mensagem});
        }
    }
}