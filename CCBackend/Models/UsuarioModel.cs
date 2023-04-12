using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Usuario")]
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Usuario_Id")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Falta ingresar el nombre de usuario.")]
        [Column("Nombre_Usuario")]
        [NotNull]
        [StringLength(255)]
        public string? NombreUsuario { get; set; }

        [Required(ErrorMessage ="Falta ingresar el Rut.")]
        [StringLength(15)]
        [NotNull]
        public string? Rut { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Falta ingresar la dirección de correo.")]
        [NotNull]
        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/", ErrorMessage ="El correo ingresado no es valido")]
        [StringLength(45)]
        public string? Correo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [AllowNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Updated_At")]
        public DateTime? UpdatedAt { get; set; }
    }
}
