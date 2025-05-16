using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("usuarios")]
public class Usuario
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string Login { get; set; }

    [Required]
    [StringLength(255)]
    public string SenhaHash { get; set; }

    [StringLength(50)]
    public string Tipo { get; set; } 

  
    public Guid  ClienteId { get; set; }
    public Guid ProfissionalId { get; set; }


    public virtual Cliente Cliente { get; set; }
    public virtual Profissional Profissional { get; set; }
}