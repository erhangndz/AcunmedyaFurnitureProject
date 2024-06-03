using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.ViewComponents.UILayout
{
	public class _UILayoutHeadComponent:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
