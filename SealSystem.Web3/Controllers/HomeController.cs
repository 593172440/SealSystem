using Newtonsoft.Json;
using SealSystem.Web3.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //这里后期可以简化!!!!!!!!!!!!!!!!!!!!
            List<int> meun = new List<int>();//保存菜单id
            Models.SSContext db = new Models.SSContext();//数据上下文
            var menusId = db.UserPermissions.Where(m => m.User_Id == user.Id);//获取所有的菜单id
            foreach (var item in menusId)
            {
                meun.Add(item.Menu_Id);
            }
            List<Models.MenuTable> menusData = db.MenuTables.Where(m => meun.Contains(m.Id)).ToList();
            //////////////////////////////////////
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            List<string> sb5 = new List<string>();
            foreach (var item in menusData)
            {
                if (!string.IsNullOrEmpty(item.MenuPath) && item.SuperiorCodeId == 100)
                {
                    sb1.Append(item.MenuPath);
                }
                if (!string.IsNullOrEmpty(item.MenuPath) && item.SuperiorCodeId == 200)
                {
                    sb2.Append(item.MenuPath);
                }
                if (!string.IsNullOrEmpty(item.MenuPath) && item.SuperiorCodeId == 300)
                {
                    sb3.Append(item.MenuPath);
                }
                if (!string.IsNullOrEmpty(item.MenuPath) && item.SuperiorCodeId == 400)
                {
                    sb4.Append(item.MenuPath);
                }
                if (item.Add) { sb5.Add(item.Name + ":Add"); }
                if (item.Delete) { sb5.Add(item.Name + ":Delete"); }
                if (item.Details) { sb5.Add(item.Name + ":Details"); }
                if (item.Edit) { sb5.Add(item.Name+":Edit"); }
            }
            Response.Cookies.Add(new HttpCookie("XinXiDengJi")
            {

                Value = HttpUtility.UrlEncode(sb1.ToString())

                //Expires = DateTime.Now.AddHours(1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("ShengChanGuanLi")
            {

                Value = HttpUtility.UrlEncode(sb2.ToString())

                //Expires = DateTime.Now.AddHours(1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("XinXiChaXun")
            {

                Value = HttpUtility.UrlEncode(sb3.ToString())

                //Expires = DateTime.Now.AddHours(1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("HouTaiSheZhi")
            {

                Value = HttpUtility.UrlEncode(sb4.ToString())

                //Expires = DateTime.Now.AddHours(1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("ZXGC")
            {
                Value = HttpUtility.UrlEncode(JsonConvert.SerializeObject(sb5))
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
            Response.Cookies.Add(new HttpCookie("XinXiDengJi")
            {
                Expires = DateTime.Now.AddHours(-1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("ShengChanGuanLi")
            {
                Expires = DateTime.Now.AddHours(-1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("XinXiChaXun")
            {
                Expires = DateTime.Now.AddHours(-1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("HouTaiSheZhi")
            {
                Expires = DateTime.Now.AddHours(-1)//cookie保存1小时
            });
            Response.Cookies.Add(new HttpCookie("ZXGC")
            {
                Expires = DateTime.Now.AddHours(-1)//cookie保存1小时
            });
            return RedirectToAction("LoginIndex", "Home");
        }

    }
}