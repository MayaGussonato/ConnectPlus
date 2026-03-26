using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectPlus.WebAPI.Models;

[Table("Contato")]
public partial class Contato
{
    [Key]
    public Guid IdContato { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string FormaContato { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Imagem { get; set; }

    public Guid IdTipoContato { get; set; }

    [ForeignKey("IdTipoContato")]
    [InverseProperty("Contatos")]
    public virtual TipoContato IdTipoContatoNavigation { get; set; } = null!;
}