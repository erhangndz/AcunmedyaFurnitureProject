using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
