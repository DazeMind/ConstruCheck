using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Comerce")]
    public class CommerceModel
    {
        [Key]
        [Column("Commerce_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommerceId { get; set;}

        [Required(ErrorMessage = "Debe ingresar un nombre.")]
        [StringLength(50)]
        [Column("Commerce_Name")]
        public string? CommerceName { get; set;}

        [AllowNull]
        [StringLength(255)]
        [Column("Commerce_Description")]
        public string? CommerceDescription { get; set;}


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<ProductModel>? Products { get; set;}
    }
}
