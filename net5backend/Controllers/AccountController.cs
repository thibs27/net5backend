using Microsoft.AspNetCore.Mvc;
using net5backend.ViewModels;
using System.Threading.Tasks;

namespace net5backend.Controllers
{
    public class AccountController : Controller
    {
		public IActionResult Login()
		{
			if (this.User.Identity.IsAuthenticated)
			{
				return View();
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				return View();
			}
			ModelState.AddModelError("", "Failed to login");
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Logout()
		{
			return View();
		}

	}
}
