using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    // Dois pontos Heranca(mais para frente)
    public class RacaController : Controller
    {
        /// <summary>
        /// Endpoint que permite listar todas as racas
        /// </summary>
        /// <returns>Retorna a pagina html com as racas</returns>
        [Route("/raca")]
        [HttpGet]
        public IActionResult ObterTodos()
        {
            return View("Index");
        }

        [Route("/raca/cadastrar")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("/raca/registrar")]
        [HttpGet]
        public IActionResult Registrar(
            [FromQuery] string nome,
            [FromQuery] string especie)
        {
            return RedirectToAction("Index");
        }
    }
}
