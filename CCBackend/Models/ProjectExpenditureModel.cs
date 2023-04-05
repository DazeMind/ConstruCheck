using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Project_Expenditure")]
    public class ProjectExpenditureModel
    {
        [Key]
        [Column("Project_Expenditure_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectExpenditureId { get; set; }

        [ForeignKey("Project_Id")]
        public int ProjectId { get; set; }

        public virtual ProjectModel? Project { get; set; }

        [Required(ErrorMessage = "Debe indicar un monto.")]
        [NotNull]
        public int Amount { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Description { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Date { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }
    }
}
