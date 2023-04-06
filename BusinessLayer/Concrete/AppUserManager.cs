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
	public class AppUserManager : IAppUserService
	{
		IAppUserService _appUserDal;

		public AppUserManager(IAppUserService appUserDal)
		{
			_appUserDal = appUserDal;
		}

		public AppUserManager(EfAppUserRepository efAppUserRepository)
		{
			EfAppUserRepository = efAppUserRepository;
		}

		public EfAppUserRepository EfAppUserRepository { get; }

		public List<AppUser> GetAll()
		{
		return _appUserDal.GetAll();
		}

		public AppUser GetById(int id)
		{
			return _appUserDal.GetById(id);
		}

		public void TAdd(AppUser entity)
		{
			_appUserDal.TAdd(entity);
		}

		public void TDelete(AppUser entity)
		{
			_appUserDal.TDelete(entity);
		}

		public void TUpdate(AppUser entity)
		{
			_appUserDal.TUpdate(entity);	
		}
	}
}
