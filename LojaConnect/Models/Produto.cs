using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaConnect.Models;
[Table("Produto")]

public class Produto
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Por favor, informe a categoria")]
    public int CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O nome deve possuir no máximo 100 caracteres")]
    public String Nome { get; set; }

    [Display(Name = "Descriçao")]
    [StringLength(1000, ErrorMessage = "O nome deve possuir no máximo 1000 caracteres")]
    public String Descricao { get; set; }

    [Required(ErrorMessage = "Por favor, informe a quantidade em estoque")]
    [Range(0, int.MaxValue)]
    [Display(Name = "Quantidade em estoque")]
    public int QtdeEstoque { get; set; }

    [Required(ErrorMessage = "Por favor, informe a quantidade o valor de custo")]
    [Range(0, double.MaxValue)]
    [Display(Name = "Valor de custo")]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorCusto { get; set; }

    [Required(ErrorMessage = "Por favor, informe a quantidade o valor de venda")]
    [Range(0, double.MaxValue)]
    [Display(Name = "Valor de venda")]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorVenda { get; set; }

    public bool Destaque { get; set; }
}
