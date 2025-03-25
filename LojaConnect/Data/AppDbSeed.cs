using LojaConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaConnect.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new() {
            new() {Id = 1, Nome = "Folhagens", Foto = "/img/categoria/1.png" },
            new() {Id = 2, Nome = "Plantas de Interior", Foto = "/img/categoria/2.png" },
            new() {Id = 3, Nome = "Vasos", Foto = "/img/categoria/3.png" },
        };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new() {
            new() {
                Id = 1,
                CategoriaId = 1,
                Nome = "Platycerum (Platycerum bifurcatum)",
                Descricao = "Apple A16 Bionic, 128GB",
                ValorCusto = 4500.00m,
                ValorVenda = 6999.99m,
                QtdeEstoque = 10,
                Destaque = true
            }
        };
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoFoto> fotos = new() {
            new() { Id = 1, ProdutoId = 1, Foto = "/img/produtos/1/1.png"},
            new() { Id = 2, ProdutoId = 1, Foto = "/img/produtos/1/2.png"},
            new() { Id = 3, ProdutoId = 1, Foto = "/img/produtos/1/3.png"},
        };
        builder.Entity<ProdutoFoto>().HasData(fotos);

    }
}
