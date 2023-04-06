
using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccesLayer.concrete
{
	public class MyContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			const string ConnetDeveloper = "server=localhost;port=3306;database=Universite;user=root;password=123456;Charset=utf8;";

			optionsBuilder.UseLazyLoadingProxies()
				.UseMySql(ConnetDeveloper, ServerVersion.AutoDetect(ConnetDeveloper))
				.EnableSensitiveDataLogging()
				.ConfigureWarnings(warnings =>
				{
					warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning);
				});

		}
		public DbSet<Announcement> Announcements { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var admin = new AppUser()
            {
                ID = 1,
                UserMail = "admin@admin.com",
                UserPassword = "123456",
                UserStatus = true
            };
           
            modelBuilder.Entity<AppUser>().HasData(admin);
            base.OnModelCreating(modelBuilder);


        }

	}
}
