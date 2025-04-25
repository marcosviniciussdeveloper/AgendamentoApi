using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using ColumnAttribute = System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{
    [Table("agendamentos")]
    public class Agendamentos: BaseModel
    {

        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("datahora")]
        public DateTime Datahora { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("id_cliente")]
        public int Id_Cliente { get; set; }

        [Column("id_profissional")]
        public int Id_Profissional { get; set; }

        [Column("id_servico")]
        public int Id_Servico { get; set; }

        public Agendamentos(DateTime datahora, int idCliente, int idProfissional, int idServico, string status)
        {
            Datahora = datahora;
            Id_Cliente = idCliente;
            Id_Profissional = idProfissional;
            Id_Servico = idServico;
            Status = status;
        }

    }
}
