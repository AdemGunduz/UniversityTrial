using BusinessLayer.Abstract;
using DataAccesLayer.Abstarct;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AnnouncementManager : IAnnouncementService
	{
		IAnnouncementDal _announcementDal;

		public AnnouncementManager(IAnnouncementDal announcementDal)
		{
			_announcementDal = announcementDal;
		}

		public List<Announcement> GetAll()
		{
			return _announcementDal.GetAll();
		}

        public Announcement GetById(int id)
        {
           return _announcementDal.GetById(id);
        }

        public void TAdd(Announcement entity)
		{
			_announcementDal.Update(entity);
		}

		public void TDelete(Announcement entity)
		{
			_announcementDal.Delete(entity);
		}

		public void TUpdate(Announcement entity)
		{
			_announcementDal.Update(entity);
		}
	}
}
