using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheateForecast.Data;
using WheateForecast.Models;

namespace WheateForecast.Controllers
{
    public class AlmoxarifatoModelsController : Controller
    {
        private readonly WheateForecastContext _context;

        public AlmoxarifatoModelsController(WheateForecastContext context)
        {
            _context = context;
        }

        // GET: AlmoxarifatoModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.AlmoxarifatoModel.ToListAsync());
        }

        // GET: AlmoxarifatoModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AlmoxarifatoModel == null)
            {
                return NotFound();
            }

            var almoxarifatoModel = await _context.AlmoxarifatoModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (almoxarifatoModel == null)
            {
                return NotFound();
            }

            return View(almoxarifatoModel);
        }

        // GET: AlmoxarifatoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlmoxarifatoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameProduct,Matricula,Forncedor,Valor,NumeroNota,Data")] AlmoxarifatoModel almoxarifatoModel)
        {
            if (ModelState.IsValid)
            {
                almoxarifatoModel.Id = Guid.NewGuid();
                _context.Add(almoxarifatoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(almoxarifatoModel);
        }

        // GET: AlmoxarifatoModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AlmoxarifatoModel == null)
            {
                return NotFound();
            }

            var almoxarifatoModel = await _context.AlmoxarifatoModel.FindAsync(id);
            if (almoxarifatoModel == null)
            {
                return NotFound();
            }
            return View(almoxarifatoModel);
        }

        // POST: AlmoxarifatoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,NameProduct,Matricula,Forncedor,Valor,NumeroNota,Data")] AlmoxarifatoModel almoxarifatoModel)
        {
            if (id != almoxarifatoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(almoxarifatoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlmoxarifatoModelExists(almoxarifatoModel.Id))
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
            return View(almoxarifatoModel);
        }

        // GET: AlmoxarifatoModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AlmoxarifatoModel == null)
            {
                return NotFound();
            }

            var almoxarifatoModel = await _context.AlmoxarifatoModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (almoxarifatoModel == null)
            {
                return NotFound();
            }

            return View(almoxarifatoModel);
        }

        // POST: AlmoxarifatoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AlmoxarifatoModel == null)
            {
                return Problem("Entity set 'WheateForecastContext.AlmoxarifatoModel'  is null.");
            }
            var almoxarifatoModel = await _context.AlmoxarifatoModel.FindAsync(id);
            if (almoxarifatoModel != null)
            {
                _context.AlmoxarifatoModel.Remove(almoxarifatoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlmoxarifatoModelExists(Guid id)
        {
          return _context.AlmoxarifatoModel.Any(e => e.Id == id);
        }

    }
}
