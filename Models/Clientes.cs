
using System.ComponentModel.DataAnnotations;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{
    [Table("clientes")]
    public class Clientes
    {

        [Key]

        public string Id { get; set; }

 
        public string Nome { get; set; }
        public int Telefone { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

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
