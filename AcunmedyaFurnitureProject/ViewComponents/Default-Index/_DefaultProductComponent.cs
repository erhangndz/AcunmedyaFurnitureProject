using AcunmedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.ViewComponents.Default_Index
{
	public class _DefaultProductComponent : ViewComponent
	{
		private readonly FurnitureContext _context;

        public _DefaultProductComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.Products.OrderByDescending(x=>x.ProductId).Take(3).ToList();

			return View(values);
		}
	}
}
