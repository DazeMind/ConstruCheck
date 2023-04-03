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
        public int AttendanceId { get; set; }

        [Required(ErrorMessage ="Debe seleccionar un trabajador.")]
        [NotNull]
        [ForeignKey("Worker_Id")]                   
        public int WorkerId { get; set; }

        [Required]
        public virtual WorkersModel? Worker { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Start_Time")]
        public DateTime? StartTime { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("End_Time")]
        public DateTime? EndTime { get; set; }

        [AllowNull]
        [Column("Hours_Total")]
        public int? HoursTotal { get; set; }
        
        [AllowNull]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Date { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        public string? Condition { get; set; }

        [Required]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_at { get; set; }

        [AllowNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Updated_at { get; set; }
    }
}
