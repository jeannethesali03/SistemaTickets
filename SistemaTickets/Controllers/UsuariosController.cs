using Microsoft.AspNetCore.Mvc;
using SistemaTickets.Models;

namespace SistemaTickets.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly TicketDbContext _context;

        public UsuariosController(TicketDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
