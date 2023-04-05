using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Client")]
    public class ClientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Client_Id")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Falta incluir un nombre.")]
        [Column("Client_Name")]
        [StringLength(255)]
        public string? ClientName { get; set; }

        [AllowNull]
        [Column("Client_Last_Name")]
        [StringLength(255)]
        public string? ClientLastName { get; set; }

        [AllowNull]
        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/", ErrorMessage = "El correo ingresado no es valido")]
        [StringLength(45)]
        public string? Email { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Company { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Membership { get; set; }

        [AllowNull]
        [Column("Phone_No")]
        public int? PhoneNo { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Address { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? City { get; set; }

        [Required]
        [DefaultValue(1)]
        public int State { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }

   
    }
}
