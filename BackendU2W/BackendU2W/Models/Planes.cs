using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Planes")]
    public class Planes
    {
        [Key]
        public int id_plan { get; set; }

        [ForeignKey("comunidad")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int id_com { get; set; }
        //Esto de abajo es una referencia a Comunidades
        public Comunidades comunidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string nombre { get; set; }

        [DefaultValue("Descripción del plan")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string? descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DuracionPlanes duracion { get; set; }

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

    public enum DuracionPlanes
    {
        Dia, Semana, Mes
    }

}
