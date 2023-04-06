﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstarct;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public List<About> GetAll()
		{
			return _aboutDal.GetAll();
		}

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TAdd(About entity)
		{
			 _aboutDal.Insert(entity);
		}

		public void TDelete(About entity)
		{
			_aboutDal.Delete(entity);
		}

		public void TUpdate(About entity)
		{
			_aboutDal.Update(entity);
		}
	}
}
