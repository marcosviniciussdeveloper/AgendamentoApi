
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoAPI.Models
{
    [Table("usuarios")]
    public class Usuarios 
    {
        [Key]
       
        public int Id { get; set; }
        public string Nome { get; set; }
       
        public DateTime CriadoEm { get; set; }
        public string Tipousuario { get; set; }

        public string SenhaHash { get; set; }   
    }

  
    public enum Tipousuario
    {
        Admin,
        Profissional,
        Cliente
    }
}
