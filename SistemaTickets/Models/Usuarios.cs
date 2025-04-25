using System.ComponentModel.DataAnnotations;

namespace SistemaTickets.Models
{
    public class Usuarios
    {
        [Key]
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
    }
}
