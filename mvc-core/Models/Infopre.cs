using System.ComponentModel.DataAnnotations;

namespace mvc_core.Models   //tabla cliente
{
    public class Infopre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public int Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Cedula { get; set; }


        public int UsuarioId { get; set; }
                

        /*IdUsuario  FechaCreacion*/


    }
}
