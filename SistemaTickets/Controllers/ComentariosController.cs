using Microsoft.AspNetCore.Mvc;

namespace SistemaTickets.Controllers
{
    public class ComentariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
