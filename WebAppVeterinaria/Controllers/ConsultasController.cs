using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    [Authorize]
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

            var consultas = _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .OrderBy(c => c.DataConsulta)
                .Where(c => c.Cliente.NomeCompleto.Contains(search));



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

        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto");
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "NomeCompleto");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Consultas.Add(consulta);
                await _context.SaveChangesAsync();
                TempData["CreateSuccess"] = "Consulta cadastrado com Sucesso";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "NomeCompleto", consulta.VeterinarioId);

            TempData["error"] = "Houve um erro ao cadastraro a consulta";
            return View(consulta);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);

            var consultaViewModel = new ConsultaViewModel();

            consultaViewModel.DataCadastro = consulta.DataCadastro; 
            consultaViewModel.DataConsulta = consulta.DataConsulta;
            consultaViewModel.DataRetorno = consulta.DataRetorno;
            consultaViewModel.Descricao = consulta.Descricao;
            consultaViewModel.Retorno = consulta.Retorno;
            consultaViewModel.Observacao = consulta.Observacao;
            consultaViewModel.NomeAnimal = consulta.NomeAnimal;
            consultaViewModel.RacaAnimal = consulta.RacaAnimal;
            consultaViewModel.TipoSexo = consulta.TipoSexo;
            consultaViewModel.TipoEspecie = consulta.TipoEspecie;
            consultaViewModel.Idade = consulta.Idade;
            consultaViewModel.Peso = consulta.Peso;
            consultaViewModel.HistoricoClinicoAnimal = consulta.HistoricoClinicoAnimal;

            if (consulta == null)
            {
                return NotFound();
            }

            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "NomeCompleto", consulta.VeterinarioId);

            return View(consultaViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Consulta consulta)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", consulta.ClienteId);
                ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "NomeCompleto", consulta.VeterinarioId);
                return View(consulta);
            }
            _context.Consultas.Update(consulta);

            await _context.SaveChangesAsync();

            TempData["updateSuccess"] = "Consulta atualizada com Sucesso";
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
            TempData["deleteSuccess"] = "Consulta excluída com Sucesso";
            return RedirectToAction("Index");
        }
    }
}
