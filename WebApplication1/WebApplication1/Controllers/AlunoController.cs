using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        static IList<Aluno> AlunoList = new List<Aluno>
        {
            new Aluno() { ID = 1, Nome = "Jonh", Idade = 18 },
            new Aluno() { ID = 2, Nome = "Steve", Idade = 21 },
            new Aluno() { ID = 3, Nome = "Bill", Idade = 25 },
            new Aluno() { ID = 4, Nome = "Ram", Idade = 20 },
            new Aluno() { ID = 5, Nome = "Ron", Idade = 31 },
            new Aluno() { ID = 4, Nome = "Chris", Idade = 17 },
            new Aluno() { ID = 4, Nome = " Bob", Idade = 19 }
        };

        public IActionResult Index()
        {
            return View(AlunoList);
        }

        //POST: Aluno/Create
        [HttpPost] 
        public IActionResult Create(Aluno AlunoInfo) 
        {
            try
            {
                AlunoList.Add(
                    new Aluno { ID = AlunoInfo.ID, Nome = AlunoInfo.Nome, Idade = AlunoInfo.Idade }
                );

                return RedirectToAction(nameof(Index)); 
            }
            catch
            {
                return View();
            }
        } 
    } 
}