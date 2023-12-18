using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitaPetBackend.Models.Rol
{
    [Table("rol")]
    public class RolModel
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
    }
}
