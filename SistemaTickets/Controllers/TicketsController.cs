using Microsoft.AspNetCore.Mvc;

namespace SistemaTickets.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
