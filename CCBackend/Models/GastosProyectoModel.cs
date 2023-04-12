using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Gastos_Proyecto")]
    public class GastosProyectoModel
    {
        [Key]
        [Column("Gastos_Proyecto_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GastosProyectoId { get; set; }

        [ForeignKey("Proyecto_Id"), Column("Proyecto_Id")]
        public int ProyectoId { get; set; }

        public virtual ProyectoModel? Proyecto { get; set; }

        [Required(ErrorMessage = "Debe indicar un monto.")]
        [NotNull]
        public int Monto { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Description { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Fecha { get; set; }

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
