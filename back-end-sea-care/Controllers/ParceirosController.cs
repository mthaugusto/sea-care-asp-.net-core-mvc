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
    public class ParceirosController : Controller
    {
        private readonly FiapDbContext _context;

        public ParceirosController(FiapDbContext context)
        {
            _context = context;
        }

        // GET: Parceiros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parceiros.ToListAsync());
        }

        // GET: Parceiros/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiro = await _context.Parceiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parceiro == null)
            {
                return NotFound();
            }

            return View(parceiro);
        }

        // GET: Parceiros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parceiros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeParceiro,Cnpj,Telefone,Setor,Email,Status,DtInicio,DtFim")] Parceiro parceiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parceiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parceiro);
        }

        // GET: Parceiros/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiro = await _context.Parceiros.FindAsync(id);
            if (parceiro == null)
            {
                return NotFound();
            }
            return View(parceiro);
        }

        // POST: Parceiros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NomeParceiro,Cnpj,Telefone,Setor,Email,Status,DtInicio,DtFim")] Parceiro parceiro)
        {
            if (id != parceiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parceiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParceiroExists(parceiro.Id))
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
            return View(parceiro);
        }

        // GET: Parceiros/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parceiro = await _context.Parceiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parceiro == null)
            {
                return NotFound();
            }

            return View(parceiro);
        }

        // POST: Parceiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var parceiro = await _context.Parceiros.FindAsync(id);
            if (parceiro != null)
            {
                _context.Parceiros.Remove(parceiro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParceiroExists(long id)
        {
            return _context.Parceiros.Any(e => e.Id == id);
        }
    }
}
