using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
