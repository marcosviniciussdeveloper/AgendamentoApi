
using System.ComponentModel.DataAnnotations.Schema;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using ColumnAttribute = Supabase.Postgrest.Attributes.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;


namespace AgendamentoAPI.Models
{
    [Table("profissionais")]
    public class _ProfissionaisController : BaseModel
    {

        [PrimaryKey("id")]

        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("areaatuacao")]
        public string Areaatuacao { get; set; }

        [Column("especialidade")]
        public string Especialidade { get; set; }

        [Column("disponibilidade")]
        public DateTime Disponibilidade { get; set; }

        public List<TipoServico> TiposServicos { get; set; }

        public _ProfissionaisController(string areaatuacao, DateTime disponibilidade)
        {
            Areaatuacao = areaatuacao;
            Disponibilidade = disponibilidade;
        }

        internal static void Add(_ProfissionaisController profissionais)
        {
            throw new NotImplementedException();
        }

        internal static void SaveChanges(Action<_ProfissionaisController> add)
        {
            throw new NotImplementedException();
        }
    }
}
