using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
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

            return View("Index",model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {

            _context.Clientes.Add(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null) return NotFound();

            _context.Clientes.FindAsync(id);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            _context.Clientes.Update(cliente);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
