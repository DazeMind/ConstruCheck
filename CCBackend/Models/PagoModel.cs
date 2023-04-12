using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{

    [Table("CC_Pago")]
    public class PagoModel
    {
        [Key]
        [Column("Pago_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PagoId { get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Trabajador_Id"), Column("Trabajador_Id")]
        public int TrabajadorId { get; set; }

        public virtual TrabajadorModel? Trabajadores { get; set; }

        [Required]
        [NotNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Fecha { get; set; }

        [Required(ErrorMessage ="Debe seleccionar una categoria")]
        [NotNull]
        [Column("Tipo_Pago")]
        [StringLength(255)]
        public string? TipoPago { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Comentarios { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Comprobante { get; set;}

        [Required(ErrorMessage = "Debe ingresar un monto")]
        [NotNull]
        public int Monto { get; set; }

        [Required]
        [NotNull]
        public string? Estado { get; set; }

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
