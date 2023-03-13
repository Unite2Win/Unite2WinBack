

using BackendU2W.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Perfiles")]
    public class Perfiles
    {
        [Key]
        public int id_perfil { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Usuarios usuarioPropietario { get; set; }

        public long? modificadoPorId { get; set; }

        public long? borradoPorId { get; set; }

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
