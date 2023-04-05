using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Attendance")]
    public class AttendanceModel
    {
        [Key]
        [Column("Attendance_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }

        [Required(ErrorMessage ="Debe seleccionar un trabajador.")]
        [NotNull]
        [ForeignKey("Worker_Id")]                   
        public int WorkerId { get; set; }

        [Required]
        public virtual WorkerModel? Worker { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Start_Time")]
        public DateTime? StartTime { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("End_Time")]
        public DateTime? EndTime { get; set; }

        [AllowNull]
        [Column("Hours_Total")]
        public int? HoursTotal { get; set; }
        
        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? Date { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        public string? Condition { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }
    }
}
