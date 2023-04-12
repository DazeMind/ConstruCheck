using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{

    [Table("CC_Proyecto_Diario")]
    public class ProyectoDiarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Proyecto_Diario_Id")]
        public int ProyectoDiarioId { get; set; }

        [ForeignKey("Proyecto_Id"), Column("Proyecto_Id")]
        public int ProyectoId { get; set; }

        public virtual ProyectoModel? Proyectos { get; set; }

        [ForeignKey("Trabajador_Id"), Column("Trabajador_Id")]
        public int TrabajadorId { get; set; }

        public virtual TrabajadorModel? Trabajadores { get; set; }

        [Required(ErrorMessage = "Debe indicar la asistencia.")]
        [NotNull]
        public int Asistencia { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Descripcion_Avanzada")]
        public string? DescripcionAvanzada { get; set; }

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
