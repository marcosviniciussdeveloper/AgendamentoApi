
using System.ComponentModel.DataAnnotations;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;


namespace AgendamentoAPI.Models
{
    [Table("profissionais")]
    public class profissionais 
    {

        [Key]

        public int Id { get; set; }

        
        public string Nome { get; set; }

    

        public string cpf { get; set; }

       
        public DateTime DataNascimento { get; set; }

       
        public string Email { get; set; }
  
        public string Telefone { get; set; }

    
        public string Areaatuacao { get; set; }

        public string Especialidade { get; set; }
        public DateTime Disponibilidade { get; set; }

        public List<TipoServico> TiposServicos { get; set; }


        public profissionais(string nome, string cpf, DateTime dataNascimento, string email, string telefone, string areaatuacao, string especialidade, DateTime disponibilidade)
        {
            Nome = nome;
            this.cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
            Telefone = telefone;
            Areaatuacao = areaatuacao;
            Especialidade = especialidade;
            Disponibilidade = disponibilidade;
        }
    }
}
