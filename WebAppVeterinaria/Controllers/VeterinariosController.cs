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
    public class VeterinariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public VeterinariosController(ApplicationDbContext context)
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

            var veterinarios = _context.Veterinarios.OrderBy(v => v.Id).Where(v => v.NomeCompleto.Contains(search));
            PagedList<Veterinario> model = new PagedList<Veterinario>(veterinarios, page, pageSize);

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Veterinario veterinario)
        {
            if (!ModelState.IsValid)
            {
                ViewData["error"] = "Houve um erro ao cadastraro a consulta";
                return View(veterinario);
            }
            _context.Veterinarios.Add(veterinario);

            await _context.SaveChangesAsync();

            TempData["success"] = "Veterinário cadastrado com Sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var detalhes = await _context.Veterinarios.FirstOrDefaultAsync(v => v.Id == id);

            return View(detalhes);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var veterinario = await _context.Veterinarios.FindAsync(id);

            return View(veterinario);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Veterinario veterinario)
        {
            if (!ModelState.IsValid) return View(veterinario);

            _context.Veterinarios.Update(veterinario);
            await _context.SaveChangesAsync();

            TempData["update"] = "Veterinário atualizado com Sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var veterinario = await _context.Veterinarios.FindAsync(id);

            return View(veterinario);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Veterinario veterinario)
        {
            if (!ModelState.IsValid) return View(veterinario);

            _context.Veterinarios.Remove(veterinario);
            await _context.SaveChangesAsync();

            TempData["delete"] = "Veterinário excluído com Sucesso";
            return RedirectToAction("Index");
        }
    }
}
