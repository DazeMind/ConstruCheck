using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Cliente")]
    public class ClienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Cliente_Id")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Falta incluir un nombre.")]
        [Column("Cliente_Nombre")]
        [StringLength(255)]
        public string? ClienteNombre { get; set; }

        [AllowNull]
        [Column("Cliente_Apellido")]
        [StringLength(255)]
        public string? ClientApellido { get; set; }

        [AllowNull]
        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/", ErrorMessage = "El correo ingresado no es valido")]
        [StringLength(45)]
        public string? Correo { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Compania { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Membresia { get; set; }

        [AllowNull]
        [Column("No_Telefono")]
        public int? NoTelefono { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Direccion { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Ciudad { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Estado { get; set; }

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
