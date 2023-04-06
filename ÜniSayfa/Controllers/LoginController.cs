using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccesLayer.concrete;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ÜniSayfa.Controllers
{
    
    public class LoginController : Controller
    {
        MyContext c = new MyContext();
     
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
      
         public async Task<IActionResult> Index(AppUser p)
        {
            MyContext c = new MyContext();
            var datavalues = c.AppUsers.FirstOrDefault(x => x.UserMail == p.UserMail && x.UserPassword == p.UserPassword );
             if (datavalues != null)
            {
               
                
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.UserMail),
                    new Claim(ClaimTypes.Role, "AppUser")
                };
                    var useridentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "AppUser");

                    
                    
                
                return View();


            }
            else
            {
                return View();
            }
                
        }
                

        }
        
    }
       

