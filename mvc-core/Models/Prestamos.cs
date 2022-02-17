using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core.Models
{
    public class Prestamos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NombreCliente { get; set; }

        [Required]
        public int InfopreId { get; set; }

        [ForeignKey("InfopreId")]
        public Infopre Infopre { get; set; }

    }
}
