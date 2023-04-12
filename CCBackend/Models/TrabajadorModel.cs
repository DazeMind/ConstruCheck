using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Trabajador")]
    public class TrabajadorModel
    {
        [Key]
        [Column("Trabajador_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrabajadorId { get; set; }

        [Required(ErrorMessage = "Falta ingresar el nombre del trabajador.")]
        [NotNull]
        [Column("Nombre_Trabajador")]
        [StringLength(255)]
        public string? NombreTrabajador { get; set; }

        [Required(ErrorMessage = "Falta ingresar el Rut.")]
        [NotNull]
        [StringLength(15)]
        public string? Rut { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe indicar una AFP")]
        [NotNull]
        [StringLength(255)]
        [Column("AFP")]
        public string? AFP { get; set; }

        [Required(ErrorMessage = "Debe indicar una prevision de salud")]
        [NotNull]
        [StringLength(255)]
        [Column("Prestacion_Salud")]
        public string? PrestacionSalud { get; set; }

        [AllowNull]
        public int Cargas { get; set; }

        [AllowNull]
        [MaxLength(2)]
        public int Talla { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string Funcion { get; set; }

        [AllowNull]
        public int Sueldo { get; set; }

        [AllowNull]
        [Column("Ciclo_Pago")]
        [StringLength(255)]
        public string CicloPago { get; set; }

        [Required]
        [StringLength(255)]
        public string? Banco { get; set; }

        [Required(ErrorMessage ="Debe indicar un tipo de cuenta"), NotNull]
        [StringLength(255)]
        [Column("Tipo_Cuenta")]
        public string? TipoCuenta { get; set; }

        [Required(ErrorMessage ="Debe indicar un numero de cuenta"), NotNull]
        [Column("No_Cuenta")]
        public string? NoCuenta { get; set; }

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
