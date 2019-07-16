using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SealSystem.Models.User user)
        {
            IDAL.IUserDAL data = new DAL.UserDAL();
            data.Add(user);
            return Content("创建成功");
        }
    }
}