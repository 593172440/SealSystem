using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Test(SealSystem.Models.User user)
        {
            IDAL.IUserDAL db = new DAL.UserDAL();
            await db.AddAsync(user);
            return View();
        }
    }
}