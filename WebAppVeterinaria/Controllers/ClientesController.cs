using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
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

            var clientes = _context.Clientes.OrderBy(x => x.Id).Where(c => c.NomeCompleto.Contains(search));
            PagedList<Cliente> model = new PagedList<Cliente>(clientes, page, pageSize);

            ViewBag.Search = search;

            return View("Index", model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var detalhes = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

            return View(detalhes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            _context.Clientes.Add(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _context.Clientes.FindAsync(id);

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            _context.Clientes.Update(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _context.Clientes.FindAsync(id);

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            _context.Clientes.Remove(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }

}
