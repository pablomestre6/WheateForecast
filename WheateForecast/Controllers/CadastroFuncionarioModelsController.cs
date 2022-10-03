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
    public class CadastroFuncionarioModelsController : Controller
    {
        private readonly WheateForecastContext _context;

        public CadastroFuncionarioModelsController(WheateForecastContext context)
        {
            _context = context;
        }

        // GET: CadastroFuncionarioModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.CadastroFuncionarioModel.ToListAsync());
        }

        // GET: CadastroFuncionarioModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CadastroFuncionarioModel == null)
            {
                return NotFound();
            }

            var cadastroFuncionarioModel = await _context.CadastroFuncionarioModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroFuncionarioModel == null)
            {
                return NotFound();
            }

            return View(cadastroFuncionarioModel);
        }

        // GET: CadastroFuncionarioModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroFuncionarioModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Setor,CPF,Identidade,NumeroTelefone,Endereco,CEP,DataAdmicao,DataNacimento")] CadastroFuncionarioModel cadastroFuncionarioModel)
        {
            if (ModelState.IsValid)
            {
                cadastroFuncionarioModel.Id = Guid.NewGuid();
                _context.Add(cadastroFuncionarioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroFuncionarioModel);
        }

        // GET: CadastroFuncionarioModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CadastroFuncionarioModel == null)
            {
                return NotFound();
            }

            var cadastroFuncionarioModel = await _context.CadastroFuncionarioModel.FindAsync(id);
            if (cadastroFuncionarioModel == null)
            {
                return NotFound();
            }
            return View(cadastroFuncionarioModel);
        }

        // POST: CadastroFuncionarioModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,Setor,CPF,Identidade,NumeroTelefone,Endereco,CEP,DataAdmicao,DataNacimento")] CadastroFuncionarioModel cadastroFuncionarioModel)
        {
            if (id != cadastroFuncionarioModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroFuncionarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroFuncionarioModelExists(cadastroFuncionarioModel.Id))
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
            return View(cadastroFuncionarioModel);
        }

        // GET: CadastroFuncionarioModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CadastroFuncionarioModel == null)
            {
                return NotFound();
            }

            var cadastroFuncionarioModel = await _context.CadastroFuncionarioModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroFuncionarioModel == null)
            {
                return NotFound();
            }

            return View(cadastroFuncionarioModel);
        }

        // POST: CadastroFuncionarioModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CadastroFuncionarioModel == null)
            {
                return Problem("Entity set 'WheateForecastContext.CadastroFuncionarioModel'  is null.");
            }
            var cadastroFuncionarioModel = await _context.CadastroFuncionarioModel.FindAsync(id);
            if (cadastroFuncionarioModel != null)
            {
                _context.CadastroFuncionarioModel.Remove(cadastroFuncionarioModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroFuncionarioModelExists(Guid id)
        {
          return _context.CadastroFuncionarioModel.Any(e => e.Id == id);
        }
    }
}
