using System.Threading.Tasks;
using LojaConnect.Data;
using LojaConnect.Models;
using Microsoft.AspNetCore.Mvc;


namespace LojaConnect.Controllers;


public class CategoriasController : Controller
{
    private readonly ILogger<CategoriasController> _logger;
    private readonly AppDbContext _db;
    private readonly IWebHostEnvironment _host;

    public CategoriasController(
        ILogger<CategoriasController> logger,
        AppDbContext db,
        IWebHostEnvironment host 
        )
    {
        _logger = logger;
        _db = db;
        _host = host;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = _db.Categorias.ToList();
        return View(categorias);
    }

    [HttpGet]
    public IActionResult create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Categoria categoria, IFormFile Arquivo) 
    {
        if (ModelState.IsValid)
        {
            _db.Categorias.Add(categoria);
            await _db.SaveChangesAsync();

            // Salvar a foto no servidor
            if (Arquivo != null)
            {
                string nomeArquivo = categoria.Id + Path.GetExtension(Arquivo.FileName);
                string caminho = Path.Combine(_host.WebRootPath, "img\\categoria");
                string novoArquivo = Path.Combine(caminho, nomeArquivo);
                using (FileStream stream = new(novoArquivo, FileMode.Create))
                {
                    Arquivo.CopyTo(stream);
                }
                categoria.Foto = "\\img\\categoria\\" + nomeArquivo;
                await _db.SaveChangesAsync();
            }

            TempData["success"] = "Categoria cadastrada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        return View(categoria);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
