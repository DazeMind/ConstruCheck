using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Project_Responsible")]
    public class ProjectResponsibleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Project_Responsible_Id")]
        
        public int ProjectResponsibleId { get; set; }

        [Required(ErrorMessage = "Debe indicar un proyecto.")]
        [ForeignKey("Project_Id")]
        public int ProjectId { get; set; }

        public virtual ProjectModel? Project { get; set; }

        [Required(ErrorMessage ="Debe indicar un nombre.")]
        [StringLength(255)]
        [Column("Responsible_Name")]
        public string? ResponsibleName { get; set; }

        [AllowNull]
        [StringLength(255)]
        [Column("Responsible_Email")]
        public string? ResponsibleEmail { get; set; }

        [AllowNull]
        [Column("Phone_No")]
        public int? PhoneNo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Updated_At")]
        public DateTime UpdatedAt { get; set; }

    }
}
