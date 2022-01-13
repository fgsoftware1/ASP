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
    public class TransacoesController : Controller
    {
        private readonly projecto_website1Context _context;

        public TransacoesController(projecto_website1Context context)
        {
            _context = context;
        }

        // GET: Transacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transacoes.ToListAsync());
        }

        // GET: Transacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaco = await _context.Transacoes
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (transaco == null)
            {
                return NotFound();
            }

            return View(transaco);
        }

        // GET: Transacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransacao,Entidade,Referencia,Produto,Data,NomeCliente")] Transaco transaco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaco);
        }

        // GET: Transacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaco = await _context.Transacoes.FindAsync(id);
            if (transaco == null)
            {
                return NotFound();
            }
            return View(transaco);
        }

        // POST: Transacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTransacao,Entidade,Referencia,Produto,Data,NomeCliente")] Transaco transaco)
        {
            if (id != transaco.IdTransacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransacoExists(transaco.IdTransacao))
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
            return View(transaco);
        }

        // GET: Transacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaco = await _context.Transacoes
                .FirstOrDefaultAsync(m => m.IdTransacao == id);
            if (transaco == null)
            {
                return NotFound();
            }

            return View(transaco);
        }

        // POST: Transacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaco = await _context.Transacoes.FindAsync(id);
            _context.Transacoes.Remove(transaco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransacoExists(int id)
        {
            return _context.Transacoes.Any(e => e.IdTransacao == id);
        }
    }
}
