using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Rate")]
    public class RateModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RateId { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        [Column("Rate_Name")]
        public string? RateName { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Start_Time")]
        public DateTime? Date { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Attachment { get; set; }

        [AllowNull]
        public int? Value { get; set; }

        [AllowNull]
        public string? Responsible { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }
    }
}
