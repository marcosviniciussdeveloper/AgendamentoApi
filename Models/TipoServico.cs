using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


[Table("servicos")]
public class TipoServico
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco { get; set; }

    public int DuracaoMinutos { get; set; } 

 
    public virtual ICollection<ProfissionalTipoServico> Profissionais { get; set; }

    public virtual ICollection<Agendamento> Agendamentos { get; set; }
}