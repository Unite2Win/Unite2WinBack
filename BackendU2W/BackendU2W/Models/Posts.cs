using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Posts")]
    public class Posts
    {
        [Key]
        public int id_post { get; set; }

        [ForeignKey("comunidadesUsuarios")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int id_com_usu { get; set; }

        public ComunidadesUsuarios? comunidadesUsuarios { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Este campo debe tener un mínimo de 1 caractéres y máximo de 50")]
        public string titulo { get; set; }

        [StringLength(500, MinimumLength = 1, ErrorMessage = "Este campo debe tener un mínimo de 1 caractéres y máximo de 50")]
        public string? descripcion { get; set; }

        [ForeignKey("imagen")]
        public long? imagenid_doc { get; set; }
        public Documentos? imagen { get; set; }

        //ESTO ESTARIA BIEN HACERLO EN UNA TABLA DONDE GUARDAMOS CADA LIKE CON EL USUARIO... ¿Dará tiempo? :0
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public long likes { get; set; }

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
