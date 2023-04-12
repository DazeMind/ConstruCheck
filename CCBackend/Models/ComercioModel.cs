using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Comercio")]
    public class ComercioModel
    {
        [Key]
        [Column("Comercio_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComercioId { get; set;}

        [Required(ErrorMessage = "Debe ingresar un nombre.")]
        [StringLength(50)]
        [Column("Nombre_Comercio")]
        public string? NombreComercio { get; set;}

        [AllowNull]
        [StringLength(255)]
        [Column("Descripcion")]
        public string? Descripcion { get; set;}


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [AllowNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Updated_At")]
        public DateTime? UpdatedAt { get; set; }

        public ICollection<ProductoModel>? Productos { get; set;}
    }
}
