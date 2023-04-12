using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Modelos
{
    [Table("CC_Interesado_Proyecto")]
    public class InteresadoProyectoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Interesado_Proyecto_Id")]
        
        public int InteresadoProyectoId { get; set; }

        [Required(ErrorMessage = "Debe indicar un proyecto.")]
        [ForeignKey("Proyecto_Id"), Column("Proyecto_Id")]
        public int ProyectoId { get; set; }

        public virtual ProyectoModel? Proyecto { get; set; }

        [Required(ErrorMessage ="Debe indicar un nombre.")]
        [StringLength(255)]
        [Column("Nombre_Responsable")]
        public string? NombreResponsable { get; set; }

        [AllowNull]
        [StringLength(255)]
        [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/", ErrorMessage = "El correo ingresado no es valido")]
        [Column("Correo_Responsable")]
        public string? CorreoResponsable { get; set; }

        [AllowNull]
        [Column("No_Telefono")]
        public int? NoTelefono { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }

        [AllowNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayFormat(DataFormatString = "{0:DD.MM.YYYY}")]
        [Column("Updated_At")]
        public DateTime? UpdatedAt { get; set; }

    }
}
