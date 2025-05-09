using System.Diagnostics;
using Cadastro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Page1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Page1(string nome, int idade)
        {
            TempData["Nome"] = nome;
            TempData["Idade"] = idade;
            return RedirectToAction("Page2");

        }
        public ActionResult Page2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Page2(string cep, string endereco)
        {
            ViewBag.Nome = TempData["Nome"];
            ViewBag.Idade = TempData["Idade"];
            ViewBag.CEP = cep;
            ViewBag.Endereço = endereco;
            return View("Resultado");
        }
    }
}
