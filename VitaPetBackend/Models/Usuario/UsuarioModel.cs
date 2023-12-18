using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitaPetBackend.Models.Usuario
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("tipo_documento")]
        public int? tipo_documento { get; set; }
                
        public int? rol { get; set; }
                
        public int? documento { get; set; }
                
        public string? primer_nombre { get; set; }
                
        public string? segundo_nombre { get; set; }
                
        public string? primer_apellido { get; set; }                
         
        public string? segundo_apellido { get; set; }
                
        public string? foto { get; set; }

        public int? veterinaria { get; set; }
    }
}
