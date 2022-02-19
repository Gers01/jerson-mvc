using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core.Models  //tabla prestamos
{
    public class Prestamos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string prestamo { get; set; }

        [Required]
        public int monto { get; set; }

        [Required]
        public int interes { get; set; }

        [Required]
        public int plazo { get; set; }

        [Required]
        public int InfopreId { get; set; }

        [ForeignKey("InfopreId")]
        public Infopre Infopre { get; set; }

    }
}
