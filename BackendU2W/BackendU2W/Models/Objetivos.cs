using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Objetivos")]
    public class Objetivos
    {
        [Key]
        public int id_obj { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string nombre { get; set; }

        public string? descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public Duracion duracion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime create_date { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> last_modified { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> delete_date { get; set; }

        //Empieza lo de la FK:
        [ForeignKey("usuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int id_usu { get; set; }
        //Esto de abajo es una referencia a Usuarios
        public Usuarios usuario { get; set; }
    }

    public enum Duracion
    {
        Dia, Semana, Mes
    }
}
