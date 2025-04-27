
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using ColumnAttribute = Supabase.Postgrest.Attributes.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;


namespace AgendamentoAPI.Models
{
    [Table("profissionais")]
    public class profissionais : BaseModel
    {

        [PrimaryKey("id")]

        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf")]

        public string cpf { get; set; }

        [Column("datanascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("areaatuacao")]
        public string Areaatuacao { get; set; }

        [Column("especialidade")]
        public string Especialidade { get; set; }

        [Column("disponibilidade")]
        public DateTime Disponibilidade { get; set; }

        public List<TipoServico> TiposServicos { get; set; }
    }
}
