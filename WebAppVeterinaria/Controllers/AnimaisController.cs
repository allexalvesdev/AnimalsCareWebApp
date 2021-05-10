using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    public class AnimaisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnimaisController(ApplicationDbContext context)
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

            var animais = _context.Animais
                .Include(c => c.Cliente)
                .OrderBy(x => x.Id)
                .Where(c => c.Nome.Contains(search) || c.Cliente.NomeCompleto.Contains(search));

            PagedList<Animal> model = new PagedList<Animal>(animais, page, pageSize);

            ViewBag.Search = search;

            return View("Index", model);
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    var listaClientes = _context.Clientes
        //        .Select(clientes => new SelectListItem { Value = clientes.Id.ToString(), Text = clientes.NomeCompleto })
        //        .ToList();

        //    return View(new AnimalViewModel { Animal = new Animal(), ClienteSelect = listaClientes });
        //}



        //[HttpPost]
        //public async Task<IActionResult> Create(Animal animal, int ClienteId)
        //{
        //    if (!ModelState.IsValid) return View(animal);

        //    _context.Animais.Add(animal);

        //    animal.Cliente = await _context.Clientes.FindAsync(ClienteId);

        //    await _context.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}

        // GET: Animals/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto");
            return View();
        }

        // POST: Animals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", animal.ClienteId);
            return View(animal);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animais.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", animal.ClienteId);
            return View(animal);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", animal.ClienteId);
                return View(animal);
            }
            _context.Animais.Update(animal);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var animal = await _context.Animais
                .Include(c => c.Cliente)
                .FirstAsync(a => a.Id == id);

            return View(animal);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Animal animal)
        {
            if (!ModelState.IsValid) return View(animal);

            _context.Animais.Remove(animal);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var detalhes = await _context.Animais
                .Include(c => c.Cliente)
                .FirstOrDefaultAsync(a => a.Id == id);

            return View(detalhes);
        }
    }
}
