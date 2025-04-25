using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;

namespace AgendamentoAPI.Models
{
    [Table("usuarios")]
    public class Usuarios : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
       
        [Column("criadoem ")]

        public DateTime CriadoEm { get; set; }


        [Column("tipousuario")]
        public string Tipousuario { get; set; }

        [Column("SenhaHash")]
        public string SenhaHash { get; set; }   
    }

  
    public enum Tipousuario
    {
        Admin,
        Profissional,
        Cliente
    }
}
