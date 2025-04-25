using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SistemaTickets.Models
{
    public class Comentarios
    {
        [Key]
        public int id_comentario { get; set; }
        public string contenido { get; set; }
        public DateTime fecha { get; set; }
        public int id_ticket { get; set; }
        public int id_usuario { get; set; }
    }
}
