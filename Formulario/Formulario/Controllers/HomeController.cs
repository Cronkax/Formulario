using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Formulario.Controllers
{
    public class HomeController : ApiController
    {
        public ActionResult Index()
        {
            ViewBag.resposta = "";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string nome, int idade)
        {
            string mensgaem = "Você chama-se " + nome + " e tem " + idade + " anos.";
            ViewVag.resposta = mensagem;
            return View();
        }
    }
}
