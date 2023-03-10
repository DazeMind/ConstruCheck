using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CCBackend.Models
{
    public class casaComercialModel
    {
        [Key]
        public int id { get; set; }
        
        [AllowNull]
        public string name { get; set; }
        
        [AllowNull]
        public string description { get; set; }
    }
}
