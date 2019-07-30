using SealSystem.Web3.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{

    public class HomeController : Controller
    {
        [LoginFilter]
        public ActionResult Index(Models.User user)
        {
            Response.Cookies.Add(new HttpCookie("entityName")
            {
                Value = HttpUtility.UrlEncode(user.EntityName)

                //Expires = DateTime.Now.AddHours(1)//cookie保存1小时
            });
            return View(user);
        }
        [LoginFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [LoginFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoginIndex()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginIndex(string userName, string userPwd)
        {
            if (ModelState.IsValid)
            {
                BLL.UserBLL user = new BLL.UserBLL();
                if (await user.Login(userName, userPwd))
                {
                    var dbData = await user.GetUserOne(userPwd);
                    //跳转
                    //判断是用Session还是用cookie
                    Session["loginName"] = userName;
                    return RedirectToAction("index", "Home", dbData);
                    //登录成功
                }
                else
                {
                    ModelState.AddModelError("", "用户名或密码有就误");
                }
            }
            return View();
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginOut()
        {
            Session.Clear();
            Response.Cookies.Add(new HttpCookie("entityName")
            {
                Expires = DateTime.Now.AddHours(-1)//cookie保存1小时
            });
            return RedirectToAction("LoginIndex", "Home");
        }

    }
}