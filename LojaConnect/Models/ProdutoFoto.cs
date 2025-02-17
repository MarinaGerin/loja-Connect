using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaConnect.Models;
[Table("ProdutoFoto")]

    public class ProdutoFoto
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Por favor, informe o produto")]
    public int ProdutoId { get; set; }

    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [StringLength(200)]
    [Required(ErrorMessage = "Por favor, informe a foto")]
    public string Foto { get; set; }

    [Display(Name = "Descriçao")]
    [StringLength(100, ErrorMessage = "A descrição deve possuirno máximo 100 caracteres")]
    public string Descricao { get; set; }
}
