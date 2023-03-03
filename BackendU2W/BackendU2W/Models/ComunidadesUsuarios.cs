using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    //[Index(nameof(apodo), IsUnique = true)]
    //[PrimaryKey(nameof(id_com_usu), nameof(id_com), nameof(id_usu))]
    public class ComunidadesUsuarios
    {
        //[Key]
        //[Column(Order = 1)]
        public int id_com_usu { get; set; }

        //[Key]
        //[Column(Order = 2)]
        [ForeignKey("comunidad")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int id_com { get; set; }
        public Comunidades comunidad { get; set; }

        //[Key]
        //[Column(Order = 3)]
        [ForeignKey("usuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int id_usu { get; set; }
        public Usuarios usuario { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string apodo { get; set; }

        [DefaultValue(1)]
        public int nivel { get; set; }

        public string? avatar { get; set; }

        public tipo_usuario tipoUsuario { get; set; }

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

    public enum tipo_usuario
    {
        Admin, Mod, Miembro
    }
}
