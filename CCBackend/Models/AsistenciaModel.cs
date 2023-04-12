using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Asistencia")]
    public class AsistenciaModel
    {
        [Key]
        [Column("Asistencia_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AsistenciaId { get; set; }

        [Required(ErrorMessage ="Debe seleccionar un trabajador.")]
        [NotNull]
        [ForeignKey("Trabajador_Id"), Column("Trabajador_Id")]                   
        public int TrabajadorId { get; set; }

        [Required]
        public virtual TrabajadorModel? Trabajador { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Inicio")]
        public DateTime? FechaInicio { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Termino")]
        public DateTime? FechaTermino { get; set; }

        [AllowNull]
        [Column("Total_Horas")]
        public int? TotalHoras { get; set; }
        
        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Fecha { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        public string? Condicion { get; set; }

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
