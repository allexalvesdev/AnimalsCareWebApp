using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;

namespace WebAppVeterinaria.Controllers
{
    [Authorize]
    public class ServicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var lista = await _context.Servicos.ToListAsync();

            return View(lista);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var detalhes = await _context.Servicos.FirstOrDefaultAsync(x => x.Id == id);

            return View(detalhes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Servico servico)
        {
            if (ModelState.IsValid)
            {
                _context.Servicos.Add(servico);
                await _context.SaveChangesAsync();

                TempData["success"] = "Serviço cadastrado com Sucesso";
                return RedirectToAction(nameof(Index));
                

            }
            else
            {
                ViewData["error"] = "Houve um erro ao cadastraro o serviço";
                return View(servico);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var servico = await _context.Servicos.FindAsync(id);

            return View(servico);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Servico servico)
        {
            if (!ModelState.IsValid) return View(servico);

            _context.Servicos.Update(servico);
            await _context.SaveChangesAsync();

            TempData["update"] = "Serviço atualizado com Sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var servico = await _context.Servicos.FindAsync(id);

            return View(servico);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Servico servico)
        {
            _context.Servicos.Remove(servico);
            await _context.SaveChangesAsync();

            TempData["delete"] = "Serviço excluído com Sucesso";
            return RedirectToAction("Index");
        }
    }
}
