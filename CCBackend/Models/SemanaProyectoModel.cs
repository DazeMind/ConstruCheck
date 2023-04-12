using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace CCBackend.Modelos
{
    [Table("CC_Semana_Proyecto")]
    public class SemanaProyectoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Semana_Proyecto_Id")]
        public int SemanaProyectoId { get; set; }

        [Required]
        [NotNull]
        public int Semana { get; set; }

        [Required]
        [NotNull]
        [Column("Metros_Avanzados")]
        public int MetrosAvanzados { get; set; }

        //foreing key with tasks
        [Required]
        [NotNull]
        [Column("Tareas_Realizadas")]
        public int TareasRealizadas { get; set; }

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
