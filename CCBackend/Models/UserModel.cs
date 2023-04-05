using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Users")]
    public class UserModel
    {
        [Key]
        [Column("User_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Falta ingresar el nombre de usuario.")]
        [Column("User_Name")]
        [NotNull]
        [StringLength(255)]
        public string? UserName { get; set; }

        [Required(ErrorMessage ="Falta ingresar el Rut.")]
        [StringLength(15)]
        [NotNull]
        public string? Rut { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Job_Position")]
        public string JobPosition { get; set; }

        [Required(ErrorMessage = "Falta ingresar la dirección de correo.")]
        [NotNull]
        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/", ErrorMessage ="El correo ingresado no es valido")]
        [StringLength(45)]
        public string? Email { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }
    }
}
