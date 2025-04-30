using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("clientes")]
public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [StringLength(100)]
    public string Email { get; set; }

    [StringLength(20)]
    public string Telefone { get; set; }

  
    public virtual ICollection<Agendamento> Agendamentos { get; set; }
}