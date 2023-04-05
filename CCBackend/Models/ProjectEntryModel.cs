using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Project_Entry")]
    public class ProjectEntryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Project_Entry_Id")]
        public int ProjectEntryId { get; set; }

        [ForeignKey("Project_Id")]
        public int ProjectId { get; set; }

        public virtual ProjectModel? Project { get; set; }

        [Required(ErrorMessage ="Debe ingresar un monto.")]
        [NotNull]
        public int Amount { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Description { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
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
