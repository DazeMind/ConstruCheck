using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Proyecto")]
    public class ProyectoModel
    {
        [Key]
        [Column("Proyecto_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProyectoId { get; set; }

        [ForeignKey("Cliente_Id"), Column("Cliente_Id")]
        [Required(ErrorMessage = "Debe seleccionar un cliente")]
        [NotNull]
        public int ClienteId { get; set; }

        public virtual ClienteModel? Cliente { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        [Column("Nombre_Proyecto")]
        public string? NombreProyecto { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Descripcion_Proyecto")]
        public string? DescripcionProyecto { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Inicio")]
        public DateTime? FechaInicio { get; set;}

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Fecha_Termino")]
        public DateTime? FechaTermino { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Estado { get; set; }

        [AllowNull]
        [Column("Metros")]
        public int? Metros { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Metros_Trabajados")]
        public string? MetersTrabajados { get; set; }

        [AllowNull]
        [Column("Valor_Total")]
        public int? ValorTotal { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Ubicacion { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Interesado { get; set; }

        [AllowNull]
        [StringLength(45)]
        [Column("Documentacion_Relacionada")]
        public string? DocumentacionRelacionada { get; set; }

        [AllowNull]
        [StringLength(45)]
        public string? Presupuesto { get; set; }

        [AllowNull]
        [StringLength(45)]
        public string? Gastos { get; set; }

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
