using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponents
{
	public class _AdminSidebarComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
