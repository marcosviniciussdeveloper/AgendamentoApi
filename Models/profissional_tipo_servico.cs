

using System.ComponentModel.DataAnnotations.Schema;


[Table("profissional_tipo_servico")]
public class ProfissionalTipoServico
{
    public int ProfissionalId { get; set; }
    public int ServicoId { get; set; }

    public virtual Profissional Profissional { get; set; }
    public virtual TipoServico Servico { get; set; }
}