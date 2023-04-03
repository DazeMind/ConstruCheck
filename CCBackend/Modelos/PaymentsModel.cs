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
        public int PaymentId { get; set; }

        [Required]
        [NotNull]
        [ForeignKey("Worker_Id")]
        public int WorkerId { get; set; }

        public virtual WorkersModel? Worker { get; set; }

        [Required]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
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
        [DefaultValue(1)]
        public int State { get; set; }

        [Required]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }

        [AllowNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Updated_at { get; set; }
    }
}
