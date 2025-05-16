using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


[Table("profissionais")]
public class Profissional
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [StringLength(15)]
    public string Telefone { get; set; }

    [Required]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [StringLength(14)]
    public string Cpf { get; set; }

    [StringLength(100)]
    public string Especialidade { get; set; }

    public virtual ICollection<ProfissionalTipoServico>? Servicos { get; set; }


    public virtual ICollection<Agendamento> ?Agendamentos { get; set; }
}