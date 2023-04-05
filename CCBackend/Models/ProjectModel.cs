using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Project")]
    public class ProjectModel
    {
        [Key]
        [Column("Project_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [ForeignKey("Client_Id")]
        [Required(ErrorMessage = "Debe seleccionar un cliente")]
        [NotNull]
        public int ClientId { get; set; }

        public virtual ClientModel? Client { get; set; }

        [Required]
        [NotNull]
        [StringLength(255)]
        [Column("Project_Name")]
        public string? ProjectName { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Project_Description")]
        public string? ProjectDescription { get; set; }

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? StartDate { get; set;}

        [AllowNull]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        public DateTime? EndDate { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? State { get; set; }

        [AllowNull]
        [Column("Meters_To_Work")]
        public int? MetersToWork { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Meters_Worked")]
        public string? MetersWorked { get; set; }

        [AllowNull]
        [Column("Total_Value")]
        public int? TotalValue { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Placement { get; set; }

        [AllowNull]
        [StringLength(255)]
        public string? Responsible { get; set; }

        [AllowNull]
        [StringLength(45)]
        [Column("Related_Document")]
        public string? RelatedDocument { get; set; }

        [AllowNull]
        [StringLength(45)]
        public string? Budget { get; set; }

        [AllowNull]
        [StringLength(45)]
        public string? Spending { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }



    }
}
