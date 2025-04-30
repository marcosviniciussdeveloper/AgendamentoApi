using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("usuarios")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Login { get; set; }

    [Required]
    [StringLength(255)]
    public string SenhaHash { get; set; }

    [StringLength(50)]
    public string Tipo { get; set; } 

  
    public int? ClienteId { get; set; }
    public int? ProfissionalId { get; set; }


    public virtual Cliente Cliente { get; set; }
    public virtual Profissional Profissional { get; set; }
}