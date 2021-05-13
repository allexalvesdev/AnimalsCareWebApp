using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    [Authorize]
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

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var animais = _context.Animais
                .Include(c => c.Cliente)
                .OrderBy(x => x.Id)
                .Where(u => u.UsuarioId == userId)
                .Where(c => c.Nome.Contains(search) || c.Cliente.NomeCompleto.Contains(search));

            PagedList<Animal> model = new PagedList<Animal>(animais, page, pageSize);

            ViewBag.Search = search;

            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto");
            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animal);
                await _context.SaveChangesAsync();

                TempData["createSuccess"] = "Animal cadastrado com Sucesso";
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", animal.ClienteId);
            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewData["error"] = "Houve um erro ao cadastraro a consulta";
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

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var animalViewModel = new AnimalViewModel();

            animalViewModel.Nome = animal.Nome;
            animalViewModel.Raca = animal.Raca;
            animalViewModel.Idade = animal.Idade;
            animalViewModel.Peso = animal.Peso;
            animalViewModel.Observacao = animal.Observacao;
            animalViewModel.TipoPelo = animal.TipoPelo;
            animalViewModel.TipoSexo = animal.TipoSexo;
            animalViewModel.TipoEspecie = animal.TipoEspecie;
            animalViewModel.Nascimento = animal.Nascimento;


            if (animal == null)
            {
                return NotFound();
            }

            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", animal.ClienteId);

            return View(animalViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", animal.ClienteId);
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return View(animal);
            }

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            _context.Animais.Update(animal);
            await _context.SaveChangesAsync();

            TempData["updateSuccess"] = "Animal atualizado com Sucesso";
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

            TempData["deleteSuccess"] = "Animal excluído com Sucesso";
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
