
using Supabase.Postgrest.Attributes;
using ColumnAttribute = System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{

     [Table("tipo_servico")]

    public class TipoServico
    {
        [PrimaryKey("id")]
    
        public int Id { get; set; }

        [Column("duracao")]
        public DateTime Duracao { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

    }
}
