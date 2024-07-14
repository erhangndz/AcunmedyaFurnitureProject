using AcunmedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.ViewComponents.Default_Index
{
	public class _DefaultTestimonialComponent: ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultTestimonialComponent(FurnitureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var values = _context.Testimonials.ToList();
			return View(values);
		}
	}
}
