
using System.ComponentModel.DataAnnotations;
using ColumnAttribute = System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{
    [Table("agendamentos")]
    public class Agendamentos 
    {

        [Key]
        public int Id { get; set; }

        
        public DateTime Datahora { get; set; }

        public string Status { get; set; }

        public int Id_Cliente { get; set; }
       
        public int Id_Profissional { get; set; }

      
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
