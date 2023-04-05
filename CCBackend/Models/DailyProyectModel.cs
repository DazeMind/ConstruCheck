using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{

    [Table("CC_Daily_Project")]
    public class DailyProyectModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Daily_Proyect_Id")]
        public int DailyProyectId { get; set; }

        [ForeignKey("Project_Id")]
        public int ProjectId { get; set; }

        public virtual ProjectModel? Project { get; set; }

        [ForeignKey("Worker_Id")]
        public int WorkerId { get; set; }

        public virtual WorkerModel? Worker { get; set; }

        [Required(ErrorMessage = "Debe indicar la asistencia.")]
        [NotNull]
        public int Attended { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Advancement_Description")]
        public string? AdvancementDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }
    }
}
