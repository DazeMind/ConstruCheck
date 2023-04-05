using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{

    [Table("CC_Payments")]
    public class PaymentsModel
    {
        [Key]
        [Column("Payment_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Worker_Id")]
        public int WorkerId { get; set; }

        public virtual WorkerModel? Worker { get; set; }

        [Required]
        [NotNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage ="Debe seleccionar una categoria")]
        [NotNull]
        [Column("Payment_type")]
        public string? PaymentType { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Comments { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Voucher { get; set;}

        [Required(ErrorMessage = "Debe ingresar un monto")]
        [NotNull]
        public int Ammount { get; set; }

        [Required]
        [NotNull]
        public string? State { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }
    }
}
