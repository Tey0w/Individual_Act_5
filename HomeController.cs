using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rustia_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataContext dataContext = new DataContext("Data Source=csb-entpro.wongph.com;Initial Catalog=ENTPROG_12106751_EFCodeFirst;User ID=12106751;Password=oW0vO5yO");

            User user = new User()
            {
                LastName = "Rustia",
                FirstName = "Franko",
                Branch = "Megamall",
                DateCreated = DateTime.Now,
            };

            dataContext.Users.Add(user);
            dataContext.SaveChanges();

            UserPermission userPermission = new UserPermission()
            {
                Name = "Admin",
                UserId = 1,
            };

            dataContext.UserPermissions.Add(userPermission);
            dataContext.SaveChanges();

            ViewBag.Title = "Home Page";
            
            return View();
        }
    }
}
