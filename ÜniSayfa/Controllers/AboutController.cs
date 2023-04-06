using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ÜniSayfa.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values = abm.GetAll();
			return View(values);
		}
	}
}
