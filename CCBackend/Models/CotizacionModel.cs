using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Cotizacion")]
    public class CotizacionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Cotizacion_Id")]
        public int CotizacionId { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        [Column("Nombre_Cotizacion")]
        public string? RateName { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Fecha_Inicio")]
        public DateTime? Date { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Adjunto { get; set; }

        [AllowNull]
        public int? Valor { get; set; }

        [AllowNull]
        public string? Responsable { get; set; }

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
