using System.ComponentModel.DataAnnotations;

namespace mvc_core.Models   //tabla cliente
{
    public class Infopre
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }

        [StringLength(100)]
        [Required]
        public string Apellido { get; set; }

        [StringLength(30)]
        [Required]
        public int Telefono { get; set; }

        [StringLength(100)]
        [Required]
        public string Direccion { get; set; }

        [StringLength(100)]
        [Required]
        public string Cedula { get; set; }

        [StringLength(30)]
        [Required]
        public int Genero { get; set; }

        [StringLength (20)]
        public int UsuarioId { get; set; }
                

        


    }
}
