using System.ComponentModel.DataAnnotations;

namespace SistemaTickets.Models
{
    public class Tickets
    {
        [Key]
        public int id_ticket { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public string prioridad { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime? fecha_resolucion { get; set; }
        public int? id_usuario_cliente { get; set; }
        public int? id_usuario_agente { get; set; }
    }
}
