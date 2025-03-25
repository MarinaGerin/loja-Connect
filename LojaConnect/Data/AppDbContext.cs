using LojaConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaConnect.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoFoto> ProdutosFotos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityUser>().ToTable("Usuario");
        builder.Entity<IdentityRole>().ToTable("Perfil");
        builder.Entity<IdentityRole<string>>().ToTable("UsuarioPerfil");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UsuarioRegras");
        builder.Entity<IdentityUserToken<string>>().ToTable("UsuarioToken");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UsuarioLogin");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("PerfilRegras");

        AppDbSeed seed = new(builder);
    }
}
