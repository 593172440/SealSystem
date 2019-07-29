using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(SealSystem.Models.User model)
        {
            if (ModelState.IsValid)
            {
                BLL.UserBLL user = new BLL.UserBLL();
                if(await user.Login(model.UserName, model.UserPwd))
                {
                    //跳转
                    //判断是用Session还是用cookie
                    Session["loginName"] = model.UserName;
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "用户名或密码有就误");
                }
            }
            return View();
       
        }
    }
}