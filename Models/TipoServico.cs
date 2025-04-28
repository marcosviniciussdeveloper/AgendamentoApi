
using System.ComponentModel.DataAnnotations;
using ColumnAttribute = System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{

     [Table("tipo_servico")]

    public class TipoServico
    {
        [Key]
    
        public int Id { get; set; }

        [Column("duracao")]
        public DateTime Duracao { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

    }
}
