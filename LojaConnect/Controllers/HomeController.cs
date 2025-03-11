using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LojaConnect.Models;
using LojaConnect.Data;
using Microsoft.EntityFrameworkCore;
using LojaConnect.ViewModels;
using System.Net.Http.Headers;

namespace LojaConnect.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        ViewData["Carrinho"] = 8;
        List<Produto> produtos = _db.Produtos
            .Where(p => p.Destaque)
            .Include(p => p.Fotos)
            .ToList();
        return View(produtos);
    }

    public IActionResult Produto(int id)
    {
        ViewData["Carrinho"] = 0;
        //Pesquisa do produto clicado
        Produto produto = _db.Produtos
            .Where(p => p.Id == id)
            .Include(p => p.Fotos)
            .Include(p => p.Categoria)
            .SingleOrDefault();

        //Lista de produtos semelhantes
        List<Produto> produtos = _db.Produtos
            .Where(p => p.Id != id && p.CategoriaId == produto.CategoriaId)
            .Include(p => p.Fotos)
            .Take(4).ToList();

        //Agrupar os produtos e os semelhantes no produtovm 
        ProdutoVM produtoVM = new()
        {
            Produto = produto,
            Semelhantes = produtos
        };

        return View(produtoVM);
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
