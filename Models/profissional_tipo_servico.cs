using Supabase.Postgrest;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace AgendamentoAPI.Models
{
    [Table("profissional_tipo_servico")]
    public class ProfissionalTipoServico : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("profissional_id")]
        public int ProfissionalId { get; set; }

        [Column("tipo_servico_id")]
        public int TipoServicoId { get; set; }

        public TipoServico TipoServico { get; set; }
        public profissionais Profissional { get; set; }
    }
}
