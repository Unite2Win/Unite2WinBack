using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    [Table("Tbl_Usuarios")]
    public class Usuarios
    {
        [Key]
        public int id_usu { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string nick { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Este campo debe tener un mínimo de 8 caractéres y máximo de 50")]
        public string password { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? surname { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string email { get; set; }

        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //public byte[] picture { get; set; }
        public Documentos? picture { get; set; }

        [DefaultValue(1)]
        //[Range(100, Int32.MaxValue)]
        //[Range(Int32.MinValue, 10)]
        public int level { get; set; }

        [DefaultValue("True")]
        public Boolean active { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> last_login { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime create_date{ get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> last_modified { get; set; }

        [DataType(DataType.Date)]
        [DefaultValue(null)]
        public Nullable<DateTime> delete_date { get; set; }

        //Esto de abajo es una referencia a Objetivos (Un usuario muchos objetivos)
        public Perfiles? perfil { get; set; }

        public List<Objetivos>? Objetivos { get; set; }

        public ICollection<ComunidadesUsuarios>? ComunidadesUsuarios { get; set; }
    }
}
