using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Ingreso_Proyecto")]
    public class IngresoProyectoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Ingreso_Proyecto_Id")]
        public int IngresoProyectoId { get; set; }

        [ForeignKey("Proyecto_Id"), Column("Proyecto_Id")]
        public int ProyectoId { get; set; }

        public virtual ProyectoModel? Proyecto { get; set; }

        [Required(ErrorMessage ="Debe ingresar un monto.")]
        [NotNull]
        public int Amount { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Description { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Date { get; set; }


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
