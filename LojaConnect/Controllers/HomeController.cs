using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LojaConnect.Models;
using LojaConnect.Data;

namespace LojaConnect.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db; 

    public HomeController(ILogger<HomeController> logger, AppDbContext db )
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        ViewData["Carrinho"] = 8;
        List<Produto> produtos = _db.Produtos.ToList();
        return View(produtos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
