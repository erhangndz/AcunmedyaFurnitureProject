using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.ViewComponents.Default_Index
{
	public class _DefaultProductComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
