using LojaConnect.Data;
using LojaConnect.Models;
using Microsoft.AspNetCore.Mvc;


namespace LojaConnect.Controllers;


public class CategoriasController : Controller
{
    private readonly ILogger<CategoriasController> _logger;
    private readonly AppDbContext _db;

    public CategoriasController(
        ILogger<CategoriasController> logger,
        AppDbContext db
        )
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = _db.Categorias.ToList();
        return View(categorias);
    }

    public IActionResult create()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
