
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoAPI.Models
{
    [Table("profissional_tipo_servico")]
    public class ProfissionalTipoServico 
    {
        [Key]
        public int Id { get; set; }

        public int ProfissionalId { get; set; }

        public int TipoServicoId { get; set; }

        public TipoServico TipoServico { get; set; }
        public profissionais Profissional { get; set; }
    }
}
