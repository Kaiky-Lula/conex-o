using System.Diagnostics;

using AT01.Models;

using Microsoft.AspNetCore.Mvc;

namespace AT01.Controllers

{

    public class HomeController : Controller
    {
        public IActionResult Page1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Page1(Pessoa pessoa)
        {
            if (ModelState.IsValid)

            {
                TempData["Pessoa"] = pessoa;
                return RedirectToAction("Page2");
            }
            return View(pessoa);
        }

        public IActionResult Page2()

        {
            return View();
        }
        [HttpPost]

        public IActionResult Page2(Endereco endereco)
        {
            if (ModelState.IsValid)

            {
                var pessoa = TempData["Pessoa"] as Pessoa;
                ViewBag.Nome = pessoa?.Nome;
                ViewBag.Idade = pessoa?.Idade;
                ViewBag.CEP = endereco.CEP;
                ViewBag.Endereco = endereco.EnderecoCompleto;
                return View("Resultado");
            }
        }

    }
}
