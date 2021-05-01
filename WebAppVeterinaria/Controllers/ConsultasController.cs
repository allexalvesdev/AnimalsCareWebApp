using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var search = Request.Query["Search"].ToString();

            var consultas = _context.Consultas.Include(c => c.Cliente).Include(c => c.Veterinario).OrderBy(c => c.DataConsulta).Where(c => c.Cliente.NomeCompleto.Contains(search));

            PagedList<Consulta> model = new PagedList<Consulta>(consultas, page, pageSize);

            return View("Index", model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var detalhes = await _context.Consultas
                 .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .FirstOrDefaultAsync(c => c.Id == id);

            return View(detalhes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var listaClientes = _context.Clientes.Select(clientes => new SelectListItem { Value = clientes.Id.ToString(), Text = clientes.NomeCompleto }).ToList();
            var listaVeterinarios = _context.Veterinarios.Select(veterinarios => new SelectListItem { Value = veterinarios.Id.ToString(), Text = veterinarios.NomeCompleto }).ToList();

            return View(new ConsultaViewModel { Consulta = new Consulta(), ClienteSelect = listaClientes, VeterinarioSelect = listaVeterinarios });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Consulta consulta, int ClienteId, int VeterinarioId)
        {
            if (!ModelState.IsValid) return View(consulta);

            _context.Consultas.Add(consulta);

            consulta.Cliente = _context.Clientes.Find(ClienteId);
            consulta.Veterinario = _context.Veterinarios.Find(VeterinarioId);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var consulta = await _context.Consultas.FindAsync(id);

            return View(consulta);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Consulta consulta)
        {
            if (!ModelState.IsValid) return View(consulta);

            _context.Consultas.Update(consulta);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var consulta = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .FirstOrDefaultAsync(m => m.Id == id);

            return View(consulta);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Consulta consulta)
        {
            if (!ModelState.IsValid) return View(consulta);

            _context.Consultas.Remove(consulta);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
