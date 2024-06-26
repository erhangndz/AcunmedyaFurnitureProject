using AcunmedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutNavbarComponent: ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

		public _AdminLayoutNavbarComponent(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.name = user.NameSurname;

            return View();
        }
    }
}
