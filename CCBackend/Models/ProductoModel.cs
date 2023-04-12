using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Productos")]
    public class ProductoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Producto_Id")]
        public int ProductoId { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        [Column("Nombre_Producto")]
        public string? NombreProducto { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Descripcion_Producto")]
        public string? DescripcionProducto { get; set;}

        [AllowNull]
        public int? Precio { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Link { get; set; }

        [ForeignKey("Comercio_Id"), Column("Comercio_Id")]
        public int ComercioId { get; set; }

        public virtual ComercioModel? Comercio { get; set; }

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
