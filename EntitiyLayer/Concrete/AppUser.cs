using CoreLayer.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public class AppUser : Entity
	{
		public string UserMail { get; set; }
		public string UserPassword { get; set; }
		public bool UserStatus { get; set; }
		
	}
}
