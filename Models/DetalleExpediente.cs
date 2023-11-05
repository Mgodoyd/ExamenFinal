using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Examen_final_DW.Models
{
    public class DetalleExpediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int idEnfermedades { get; set; }

        [Required]
        public int idEspecialesta { get; set; }

        [ForeignKey("IdExpedientes")]
        [JsonIgnore]
        public ICollection<Expediente>?  expediente { get; set; }
    }
}
