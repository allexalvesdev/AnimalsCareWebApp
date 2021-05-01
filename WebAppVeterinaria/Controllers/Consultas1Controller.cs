using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Controllers
{
    public class Consultas1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Consultas1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Consultas1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Consultas.Include(c => c.Cliente).Include(c => c.Veterinario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Consultas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas1/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id");
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "Id");
            return View();
        }

        // POST: Consultas1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataCadastro,DataConsulta,DataRetorno,Descricao,Retorno,Observacao,NomeAnimal,RacaAnimal,TipoSexo,TipoEspecie,Idade,Peso,HistoricoClinicoAnimal,ClienteId,VeterinarioId")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "Id", consulta.VeterinarioId);
            return View(consulta);
        }

        // GET: Consultas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "Id", consulta.VeterinarioId);
            return View(consulta);
        }

        // POST: Consultas1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataCadastro,DataConsulta,DataRetorno,Descricao,Retorno,Observacao,NomeAnimal,RacaAnimal,TipoSexo,TipoEspecie,Idade,Peso,HistoricoClinicoAnimal,ClienteId,VeterinarioId")] Consulta consulta)
        {
            if (id != consulta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "Id", consulta.VeterinarioId);
            return View(consulta);
        }

        // GET: Consultas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            _context.Consultas.Remove(consulta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consultas.Any(e => e.Id == id);
        }
    }
}
