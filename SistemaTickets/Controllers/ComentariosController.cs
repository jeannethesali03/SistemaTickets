using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaTickets.Models;

namespace SistemaTickets.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly TicketDbContext _context;

        public ComentariosController(TicketDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AgregarComentario([FromBody] Comentarios comentario)
        {
            var errores = new Dictionary<string, string>();

            // Validar contenido
            if (string.IsNullOrWhiteSpace(comentario.contenido))
                errores.Add("contenido", "El contenido del comentario es obligatorio.");

            // Validar ticket y usuario
            if (comentario.id_ticket <= 0)
                errores.Add("id_ticket", "El ticket es inválido.");

            if (comentario.id_usuario <= 0)
                errores.Add("id_usuario", "El usuario es inválido.");

            if (errores.Any())
                return Json(new { success = false, errors = errores });

            // Registrar la fecha actual
            comentario.fecha = DateTime.Now;

            _context.Comentarios.Add(comentario);
            _context.SaveChanges();

            return Json(new { success = true, message = "Comentario agregado correctamente." });
        }

        [HttpGet]
        [Authorize]
        public IActionResult VerComentariosPorTicket(int id_ticket)
        {
            if (id_ticket <= 0)
                return Json(new { success = false, message = "ID de ticket inválido." });

            var comentarios = _context.Comentarios
                .Where(c => c.id_ticket == id_ticket)
                .OrderBy(c => c.fecha)
                .ToList();

            return View("/Views/Comentarios/VerComentarios.cshtml", comentarios);
        }

        [HttpGet]
        [Authorize]
        public IActionResult ObtenerComentarios(int id_ticket)
        {
            if (id_ticket <= 0)
                return Json(new { success = false, message = "ID de ticket inválido." });

            var comentarios = _context.Comentarios
                .Where(c => c.id_ticket == id_ticket)
                .OrderBy(c => c.fecha)
                .Select(c => new {
                    c.id_comentario,
                    c.contenido,
                    c.fecha,
                    c.id_usuario
                }).ToList();

            return Json(comentarios);
        }
    }

}

