using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using back_end_sea_care.Models;
using back_end_sea_care.Persistencia;

namespace back_end_sea_care.Controllers
{
    public class RelatosController : Controller
    {
        private readonly FiapDbContext _context;

        public RelatosController(FiapDbContext context)
        {
            _context = context;
        }

        // GET: Relatos
        public async Task<IActionResult> Index()
        {
            var fiapDbContext = _context.Relatos.Include(r => r.Usuario);
            return View(await fiapDbContext.ToListAsync());
        }

        // GET: Relatos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relato = await _context.Relatos
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relato == null)
            {
                return NotFound();
            }

            return View(relato);
        }

        // GET: Relatos/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "NomeUsuario");
            return View();
        }

        // POST: Relatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeRelato,DescricaoRelato,LinkFoto,UsuarioId")] Relato relato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "NomeUsuario", relato.UsuarioId);
            return View(relato);
        }

        // GET: Relatos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relato = await _context.Relatos.FindAsync(id);
            if (relato == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "NomeUsuario", relato.UsuarioId);
            return View(relato);
        }

        // POST: Relatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NomeRelato,DescricaoRelato,LinkFoto,UsuarioId")] Relato relato)
        {
            if (id != relato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatoExists(relato.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "NomeUsuario", relato.UsuarioId);
            return View(relato);
        }

        // GET: Relatos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relato = await _context.Relatos
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relato == null)
            {
                return NotFound();
            }

            return View(relato);
        }

        // POST: Relatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var relato = await _context.Relatos.FindAsync(id);
            if (relato != null)
            {
                _context.Relatos.Remove(relato);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatoExists(long id)
        {
            return _context.Relatos.Any(e => e.Id == id);
        }
    }
}
