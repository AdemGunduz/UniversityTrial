using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ÜniSayfa.Controllers
{ 
	[Authorize(Roles = "AppUser")]
	public class AppUserController : Controller
	{
		AppUserManager au = new AppUserManager(new EfAppUserRepository());

		 
		public IActionResult Index()
		{
			return View();
		}


	}
}
