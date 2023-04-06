using CoreLayer.Entitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class Announcement : Entity
	{
		
		
		public string AnnouncementTitle { get; set; }
		public string AnnouncementContent { get; set; }
		public DateTime CratedDate { get; set; }
		public bool AnnouncementStatus { get; set; }
	}
}
