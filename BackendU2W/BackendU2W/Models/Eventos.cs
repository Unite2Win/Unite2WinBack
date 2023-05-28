using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Eventos")]
    public class Eventos
    {
        [Key]
        public int id_evento { get; set; }

        [ForeignKey("comunidad")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int id_com { get; set; }

        //Esto de abajo es una referencia a Comunidades
        public Comunidades? comunidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string titulo { get; set; }

        [DefaultValue("Descripción del plan")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Este campo debe tener un máximo de 1000")]
        public string? descripcion { get; set; }

        [DefaultValue("Descripción del plan")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Este campo debe tener un máximo de 1000")]
        public string? ubicacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime fechaInicio { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime fechaFin { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public long asistentes { get; set; }

        [ForeignKey("Imagen")]
        public long? Imagenid_doc { get; set; }

        public Documentos? Imagen { get; set; }

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
