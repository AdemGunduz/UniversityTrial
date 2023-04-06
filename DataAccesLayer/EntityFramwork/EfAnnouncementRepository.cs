using DataAccesLayer.Abstarct;
using DataAccesLayer.Repository;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramwork
{
	public class EfAnnouncementRepository : GenericRepository<Announcement>, IAnnouncementDal
	{

	}
}
