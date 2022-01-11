using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testeMysql.Models;

namespace testeMysql.Controllers
{
    public class SumariosController : Controller
    {
        private readonly projecto_website1Context _context;

        public SumariosController(projecto_website1Context context)
        {
            _context = context;
        }

        // GET: Sumarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sumarios.ToListAsync());
        }

        // GET: Sumarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sumario = await _context.Sumarios
                .FirstOrDefaultAsync(m => m.IdSumario == id);
            if (sumario == null)
            {
                return NotFound();
            }

            return View(sumario);
        }

        // GET: Sumarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sumarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSumario,Sumario1,Disciplina,AlunosPresentes,AlunosFalta")] Sumario sumario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sumario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sumario);
        }

        // GET: Sumarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sumario = await _context.Sumarios.FindAsync(id);
            if (sumario == null)
            {
                return NotFound();
            }
            return View(sumario);
        }

        // POST: Sumarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSumario,Sumario1,Disciplina,AlunosPresentes,AlunosFalta")] Sumario sumario)
        {
            if (id != sumario.IdSumario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sumario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SumarioExists(sumario.IdSumario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sumario);
        }

        // GET: Sumarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sumario = await _context.Sumarios
                .FirstOrDefaultAsync(m => m.IdSumario == id);
            if (sumario == null)
            {
                return NotFound();
            }

            return View(sumario);
        }

        // POST: Sumarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sumario = await _context.Sumarios.FindAsync(id);
            _context.Sumarios.Remove(sumario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SumarioExists(int id)
        {
            return _context.Sumarios.Any(e => e.IdSumario == id);
        }
    }
}
