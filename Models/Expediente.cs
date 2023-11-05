using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Examen_final_DW.Models
{
    public class Expediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public string fechaExpediente { get; set; }

        [Required]
        public int idEnfermedad { get; set; }

        [Required]
        public int idPaciente { get; set; }


        [Required]
        public int? idexpediente { get; set; }
        public DetalleExpediente? detalleExpediente { get; set; }

       

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime createdDate { get; set; }

        public Expediente()
        {
            createdDate = DateTime.Now;
        }

    }
}
