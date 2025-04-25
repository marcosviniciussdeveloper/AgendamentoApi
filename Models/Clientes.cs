
using System.ComponentModel.DataAnnotations.Schema;
using Supabase.Postgrest.Attributes;
using ColumnAttribute = Supabase.Postgrest.Attributes.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{

    [Table("clientes")]    

    public class Clientes
    {

        [PrimaryKey("id")]

        [Column("id")]
        public string Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("telefone")]
        public int Telefone { get; set; }

        [Column("email")]
        public string Email { get; set; }


        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("historico")]
        public string Historico { get; set; }   


        

        public Clientes( int telefone, string email, string cpf, string historico)
        {
      
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Historico = historico;
        }

    }
}
