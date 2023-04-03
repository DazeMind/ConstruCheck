using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Workers")]
    public class WorkersModel
    {
        [Key]
        [Column("Worker_Id")]
        public int WorkersId { get; set; }

        [Required(ErrorMessage = "Falta ingresar el nombre del trabajador.")]
        [NotNull]
        [Column("Worker_Name")]
        [StringLength(255)]
        public string? WorkerName { get; set; }

        [Required(ErrorMessage = "Falta ingresar el Rut.")]
        [NotNull]
        [StringLength(15)]
        public string? Rut { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("D_O_B")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Debe indicar una AFP")]
        [NotNull]
        [StringLength(255)]
        [Column("AFP")]
        public string? Afp { get; set; }

        [Required(ErrorMessage = "Debe indicar una prevision de salud")]
        [NotNull]
        [StringLength(255)]
        [Column("Health_Insurance")]
        public string? HealthInsurance { get; set; }

        [AllowNull]
        public int Charges { get; set; }

        [AllowNull]
        [MaxLength(2)]
        public int Size { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string Job { get; set; }

        [AllowNull]
        public float Payment { get; set; }

        [AllowNull]
        [Column("Pay_Frequency")]
        public string PayFrequency { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string Bank { get; set; }

        [Required(ErrorMessage ="Debe indicar un tipo de cuenta"), NotNull]
        [StringLength(255)]
        [Column("Account_Type")]
        public string? AccountType { get; set; }

        [Required(ErrorMessage ="Debe indicar un numero de cuenta"), NotNull]
        [Column("Account_number")]
        public string? AccountNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Created_At")]
        public DateTime UpdatedAt { get; set; }
        
    }
}
