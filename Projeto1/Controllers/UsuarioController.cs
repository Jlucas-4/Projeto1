using Microsoft.AspNetCore.Mvc;
using Projeto1.Repositorio;

namespace Projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        /* DECLAANDO UMA VARIAVEL PRIVADA SOMENTE PARA LEITURA DO TIPO 
         * UsuarioRepositorio chamada _usuarioRepositorio */
        private readonly UsuarioRepositorio _usuarioRepositorio;
        // DEFININDO O CONSTRUTOR DA CLASSE UsuarioController QUE VAI RECEBER UMA INSTANCIA DE UM UsuarioRepositorio
        public UsuarioController (UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }
    }
}