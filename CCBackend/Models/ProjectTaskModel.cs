using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Project_Task")]
    public class ProjectTaskModel
    {
        [Key]
        [Column("Project_Taks_Id")]
        public int ProjectTaskId { get; set; }

        [ForeignKey("Project_Id")]
        public int ProjectId { get; set; }

        public virtual ProjectModel? Project { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Task_Name")]
        public string? TaskName { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Task_Description")]
        public string? TaskDescription { get; set;}

        [AllowNull]
        [StringLength(255)]
        public string? TaskStatus { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }

        [AllowNull]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("End_Date")]
        public DateTime? EndDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }

    }
}
