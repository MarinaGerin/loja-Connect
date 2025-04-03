using LojaConnect.Models;
using Microsoft.AspNetCore.Identity;
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
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 20.00m,
                ValorVenda = 45.00m,
                QtdeEstoque = 10,
                Destaque = true
            },
            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Filodendro Birkin (Philodendron birkin)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 15.99m,
                ValorVenda = 69.90m,
                QtdeEstoque = 8,
                Destaque = true
            },
            new() {
                Id = 3,
                CategoriaId = 1,
                Nome = "Begônia Prateada (Begonia aconitifolia)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 7.90m,
                ValorVenda = 24.90m,
                QtdeEstoque = 7,
                Destaque = true
            },
            new() {
                Id = 4,
                CategoriaId = 1,
                Nome = "Begônia Cruz de Ferro (Begonia masoniana)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 5.00m,
                ValorVenda = 20.00m,
                QtdeEstoque = 5,
                Destaque = true
            },
            new() {
                Id = 5,
                CategoriaId = 1,
                Nome = "Calatéia Rufibarba (Calathea rufibarba)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 20.00m,
                ValorVenda = 39.90m,
                QtdeEstoque = 3,
                Destaque = true
            },
            new() {
                Id = 6,
                CategoriaId = 1,
                Nome = "Begônia Sementacea (Begonia x sementaceae)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 10.00m,
                ValorVenda = 22.00m,
                QtdeEstoque = 9,
                Destaque = true
            },
            new() {
                Id = 7,
                CategoriaId = 1,
                Nome = "Calatéia Tricolor (Sromanthe sanguinea variegata)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 30.00m,
                ValorVenda = 44.00m,
                QtdeEstoque = 1,
                Destaque = true
            },
            new() {
                Id = 8,
                CategoriaId = 1,
                Nome = "Asplênio (Asplenium nidus)",
                Descricao = "Imagens meramente ilustrativas. Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. Nome Popular: Platycerum, Chifre de veado.Nome Científico: Platycerum bifurcatum. Origem: Oceania.Família Botânica: Polypodiaceae.Dimensão(m): 0.6Luminosidade: Meia Sombra. Rega: 1 a 2 vezes por semana",
                ValorCusto = 8.00m,
                ValorVenda = 22.00m,
                QtdeEstoque = 5,
                Destaque = true
            },

};
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoFoto> fotos = new() {
            new() { Id = 1, ProdutoId = 1, Foto = "/img/produtos/1/Platycerum.png"},
            new() { Id = 2, ProdutoId = 2, Foto = "/img/produtos/2/birkin.png"},
            new() { Id = 3, ProdutoId = 3, Foto = "/img/produtos/3/begonia prateada.png"},
            new() { Id = 4, ProdutoId = 4, Foto = "/img/produtos/4/begonia cruz.png"},
            new() { Id = 5, ProdutoId = 5, Foto = "/img/produtos/5/calateia.png"},
            new() { Id = 6, ProdutoId = 6, Foto = "/img/produtos/6/begonia sementacea.png"},
            new() { Id = 7, ProdutoId = 7, Foto = "/img/produtos/7/tricolor.png"},
            new() { Id = 8, ProdutoId = 8, Foto = "/img/produtos/8/asplenio.png"},
        };
        builder.Entity<ProdutoFoto>().HasData(fotos);
        #region Populate Roles - Perfil de Usuario
        List<IdentityRole> roles = new()
        {
            new IdentityRole(){
                Id ="0b44ca04-f6b0-4a8f-a953-1f2330d30894",
                Name ="Administrador",
                NormalizedName ="ADMINISTRADOR"
            },
            new IdentityRole(){
                Id ="bec71b05-8f3d-4849-88bb-0e8d518d2de8",
                Name ="Funcionário",
                NormalizedName ="FUNCIONÁRIO"
            },
            new IdentityRole(){
                Id ="ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Name ="Cliente",
                NormalizedName ="CLIENTE"
            },

        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuario
        List<Usuario> usuarios = new() {
            new Usuario(){

                Id = "ddf093a6-6cb5-9a64-83da34aee005",
                Email = "mgerin2211@gmail.com",
                NormalizedEmail = "MGERIN2211@GMAIL.COM",
                UserName = "sol",
                NormalizedUserName = "SOL",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Marina Gerin",
                DataNascimento = DateTime.Parse("22/11/2006"),
                Foto = ""
            }
        };
        foreach (var user in usuarios)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "12345678");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}
