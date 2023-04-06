	using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramwork;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ÜniSayfa.Controllers
{
	 [Authorize(Roles = "AppUser")]
	public class AnnouncementsController : Controller
	{
		
		AnnouncementManager anm = new AnnouncementManager(new EfAnnouncementRepository());
		[AllowAnonymous]
		public IActionResult Index()
		{
			var values = anm.GetAll();
			return View(values);
		}

		[HttpPost]
		public IActionResult Delete(Announcement announcement, int id)
		{
			announcement.ID = id;
			anm.TDelete(announcement);
            return RedirectToAction("List", "Announcements");
        }
		
       


        public IActionResult List(Announcement announcement)
		{
			var list = anm.GetAll();
			return View(list);
		}
	    public IActionResult Edit(int id)
        {
            var result = anm.GetById(id);
            return View(result);


        }

        [HttpPost]
		public IActionResult Edit(Announcement announcement , int id)
		{
			announcement.ID=id;
			announcement.AnnouncementStatus = true;
			anm.TUpdate(announcement);
            return RedirectToAction("List", "Announcements");

        }
       



        [HttpPost]
		public IActionResult Create(Announcement announcement)
		{
			anm.TAdd(announcement);
			return RedirectToAction("List", "Announcements");
		}
        public IActionResult Create()
		{
			return View();
		}

    }

}
