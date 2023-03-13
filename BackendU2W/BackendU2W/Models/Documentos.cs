using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendU2W.Models
{
    [Table("Tbl_Documentos")]
    public class Documentos
    {
        [Key]
        public long id_doc { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public byte[] data { get; set; }

        [DefaultValue("Descripción del documento")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Este campo debe tener un máximo de 1000")]
        public string? descripcion { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "Este campo debe tener un máximo de 20")]
        public string? extensionArchivo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime create_date { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> last_modified { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> delete_date { get; set; }
    }
}
