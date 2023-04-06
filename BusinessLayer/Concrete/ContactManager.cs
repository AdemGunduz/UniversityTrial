using BusinessLayer.Abstract;
using DataAccesLayer.EntityFramwork;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactService _contactDal;
		private EfContactRepository efContactRepository;

		public ContactManager(IContactService contactDal)
		{
			_contactDal = contactDal;
		}

		public ContactManager(EfContactRepository efContactRepository)
		{
			this.efContactRepository = efContactRepository;
		}

		public List<Contact> GetAll()
		{
			return _contactDal.GetAll();	
		}

		public Contact GetById(int id)
		{
			return _contactDal.GetById(id);
		}

		public void TAdd(Contact entity)
		{
			_contactDal.TAdd(entity);
		}

		public void TDelete(Contact entity)
		{
			_contactDal.TDelete(entity);
		}

		public void TUpdate(Contact entity)
		{
			_contactDal.TUpdate(entity);	
		}
	}
}
