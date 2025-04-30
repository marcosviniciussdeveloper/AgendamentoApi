
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("agendamentos")]
public class Agendamento
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime DataHora { get; set; }

    [Required]
    [StringLength(50)]
    public string Status { get; set; } 

 
    public int ClienteId { get; set; }
    public int ProfissionalId { get; set; }
    public int ServicoId { get; set; }

  
    public virtual Cliente Cliente { get; set; }
    public virtual Profissional Profissional { get; set; }
    public virtual TipoServico Servico { get; set; }

  
    public string Observacoes { get; set; }
}