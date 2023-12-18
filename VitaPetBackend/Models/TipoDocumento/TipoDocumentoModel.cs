using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitaPetBackend.Models.TipoDocumento
{
    [Table("tipo_documento")]
    public class TipoDocumentoModel
    {
        [Key]
        public int id { get; set; }
        public string sigla { get; set; }
        public string documento { get; set; }
    }
}
