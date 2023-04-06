using CoreLayer.Entitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
	public  class About : Entity
	{
		public string AboutDetails { get; set; }
		public bool AboutStatus { get; set; }
	}
}
