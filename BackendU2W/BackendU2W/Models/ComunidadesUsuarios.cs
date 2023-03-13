using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendU2W.Models
{
    //[PrimaryKey(nameof(id_com_usu), nameof(id_com), nameof(id_usu))]
    [Table("Tbl_ComunidadesUsuarios")]
    //[Index(nameof(id_com), nameof(id_usu), IsUnique = true)]
    public class ComunidadesUsuarios
    {
        //[Column(Order = 1)]
        [Key]
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

        public ICollection<Posts> Posts { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Este campo debe tener un máximo de 50")]
        public string apodo { get; set; }

        [DefaultValue(1)]
        public int nivel { get; set; }

        public Documentos? avatar { get; set; }

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
