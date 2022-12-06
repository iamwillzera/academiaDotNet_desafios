using Microsoft.AspNetCore.Mvc;

namespace PlannerSemanal.Controllers
{
    public class AtividadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
