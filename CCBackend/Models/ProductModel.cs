using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Product")]
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Product_Id")]
        public int ProductId { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        [Column("Product_Name")]
        public string? ProductName { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Product_Description")]
        public string? ProductDescription { get; set;}

        [AllowNull]
        public int? Price { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Link { get; set; }

        [ForeignKey("Commerce_Id")]
        public int CommerceId { get; set; }

        public virtual CommerceModel? Commerce { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }

    }
}
