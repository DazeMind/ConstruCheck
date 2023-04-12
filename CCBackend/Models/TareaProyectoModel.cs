using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Tareas_Proyecto")]
    public class TareaProyectoModel
    {
        [Key]
        [Column("Tarea_Proyecto_Id")]
        public int TareaProyectoId { get; set; }

        [ForeignKey("Proyecto_Id"), Column("Proyecto_Id")]
        public int ProyectoId { get; set; }

        public virtual ProyectoModel? Proyecto { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Nombre_Tarea")]
        public string? NombreTarea { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Descripcion")]
        public string? Descripcion { get; set;}

        [AllowNull]
        [StringLength(255)]
        [Column("Estado_Tarea")]
        public string? EstadoTarea { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Inicio")]
        public DateTime? FechaInicio { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Termino")]
        public DateTime? FechaTermino { get; set; }

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
