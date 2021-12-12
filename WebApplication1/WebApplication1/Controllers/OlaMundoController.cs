using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class OlaMundoController : Controller
    {
        // GET: OlaMundoController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult BemVindo(string nome, int NumVezes)
        {
            ViewData["Mensagem"] = "Olá " + nome;
            ViewData["NumVezes"] = NumVezes;

            return View();
        }

        // GET: OlaMundoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OlaMundoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OlaMundoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OlaMundoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OlaMundoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OlaMundoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OlaMundoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
