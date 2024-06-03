using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
