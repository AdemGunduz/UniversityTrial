using CoreLayer.Entitiy;
using DataAccesLayer.Abstarct;
using DataAccesLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
	public class GenericRepository<T>: IGenericDal<T> where T : class
	{
		public void Delete(T entity)
		{
			using var c = new MyContext();
			c.Remove(entity);
			c.SaveChanges();
		}

		public List<T> GetAll()
		{
			using var c = new MyContext();
			return c.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			using var c = new MyContext();
		 return	c.Set<T>().Find(id);
		}

		public void Insert(T entity)
		{
			using var c = new MyContext();
			c.Add(entity);
			c.SaveChanges();
		}

		public void Update(T entity)
		{
			using var c = new MyContext();
			c.Update(entity);
			c.SaveChanges(); 
		}
	}
}
