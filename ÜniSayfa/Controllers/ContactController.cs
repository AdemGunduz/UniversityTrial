using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ÜniSayfa.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());
		public IActionResult Index()
		{
			return View();
		}
	}
}
