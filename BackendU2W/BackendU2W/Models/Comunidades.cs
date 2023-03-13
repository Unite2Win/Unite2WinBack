using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Comunidades")]
    public class Comunidades
    {
        [Key]
        public int id_com { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombre { get; set; }

        [DefaultValue("Descripcion de la comunidad")]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Este campo debe tener un mínimo de 1 caracter y máximo de 1000")]
        public string? descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Este campo debe tener un mínimo de 8 caractéres y máximo de 50")]
        public string clave { get; set; }

        //[Required(ErrorMessage = "Este campo es obligatorio")]
        public Documentos? picture { get; set; }

        //[Required(ErrorMessage = "Este campo es obligatorio")]
        public Documentos? banner { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime create_date { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> last_modified { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> delete_date { get; set; }

        //Esto de abajo es una referencia a Objetivos (Un usuario muchos objetivos)
        public List<Planes> Planes { get; set; }

        public ICollection<ComunidadesUsuarios> ComunidadesUsuarios { get; set; }
    }
}
