using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace CCBackend.Modelos
{
    [Table("CC_Project_Week")]
    public class ProjectWeekModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Project_Week_Id")]
        public int ProjectWeekId { get; set; }

        [Required]
        [NotNull]
        public int Week { get; set; }

        [Required]
        [NotNull]
        [Column("Meters_Done")]
        public int MetersDone { get; set; }

        //foreing key with tasks
        [Required]
        [NotNull]
        [Column("Taks_Done")]
        public int TasksDone { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }

    }
}
