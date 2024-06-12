using AcunmedyaFurnitureProject.DataAccess.Context;
using AcunmedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class ProductController : Controller
	{
		private readonly FurnitureContext _context;

		public ProductController(FurnitureContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.Products.ToList();
			return View(values);
		}

		public IActionResult DeleteProduct(int id)
		{
			var value = _context.Products.Find(id);
			_context.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");

		}

		public IActionResult CreateProduct()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateProduct(Product product)
		{
			_context.Add(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
