
using System.ComponentModel.DataAnnotations;

namespace Blog_MVC.Models;

public class Postagem
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    public int CategoriaId { get; set; }

    public Categoria Categoria { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataPostagem { get; set; }

    public string Descricao { get; set; }
    public String Texto { get; set; }

    public String Foto { get; set; }
    public string Thumbnail { get; set; }
}
