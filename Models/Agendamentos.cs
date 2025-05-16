
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

[Table("agendamentos")]
public class Agendamento
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
   
    [Required]
    public DateTime DataHora { get; set; }

    [Required]
    [StringLength(50)]
    public string Status { get; set; }
   

    public Guid ClienteId { get; set; }
    public Guid ProfissionalId { get; set; }
    public Guid ServicoId { get; set; }

  
    public virtual Cliente Cliente { get; set; }
    public virtual Profissional Profissional { get; set; }
    public virtual TipoServico Servico { get; set; }

  
    public string Observacoes { get; set; }
}