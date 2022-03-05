using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_core.Models  //tabla prestamos
{
    public class Prestamos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Idprestamo { get; set; }

        
        [Required]
        [StringLength(100)]
        public int monto { get; set; }

        
        [Required]
        public int Interes { get; set; }

        [Required]
        public int plazo { get; set; }

        [StringLength(40)]
        [Required]
        public string Montocuotas { get; set; }

        [Required]
        public int InfopreId { get; set; }

        [ForeignKey("InfopreId")]
        public Infopre Infopre { get; set; }

    }
}
