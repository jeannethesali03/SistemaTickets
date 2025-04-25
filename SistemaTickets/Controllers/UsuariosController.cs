using Microsoft.AspNetCore.Mvc;

namespace SistemaTickets.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
