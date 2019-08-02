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
            List<string> sb5 = new List<string>();
            List<string> sb6 = new List<string>();//保存权限表中的菜单Id和标识符"Add";格式:1:Add

            Response.Cookies.Add(new HttpCookie("entityName")
            {
                Value = HttpUtility.UrlEncode(user.EntityName)

                //Expires = DateTime.Now.AddHours(1)//cookie保存1小时
            });
            //这里后期可以简化!!!!!!!!!!!!!!!!!!!!
            List<int> meunId = new List<int>();//保存菜单id
            Models.SSContext db = new Models.SSContext();//数据上下文
            var menusId = db.UserPermissions.Where(m => m.User_Id == user.Id);//根据用户名获取所有的相应的菜单Id
            foreach (var item in menusId)//获取每个权限的详细信息
            {
                meunId.Add(item.Menu_Id);
                if (item.Add) { sb6.Add(item.Menu_Id + ":Add"); }
                if (item.Delete) { sb6.Add(item.Menu_Id + ":Delete"); }
                if (item.Details) { sb6.Add(item.Menu_Id + ":Details"); }
                if (item.Edit) { sb6.Add(item.Menu_Id + ":Edit"); }
            }
            List<Models.MenuTable> menusData = db.MenuTables.Where(m => meunId.Contains(m.Id)).ToList();//根据菜单Id在菜单表里获取相应的菜单
            //////////////////////////////////////
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();

            foreach (var item in menusData)//获取菜单
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
                //sb6里面保存都admin:菜单Id:Add
                //sb6.Add(item.Id, item.Name);
                if (sb6.Count>0)
                {
                    foreach (var item2 in sb6)
                    {
                        if(item2.Split(':')[0]==item.Id.ToString())
                        sb5.Add(user.UserName + ":" + item.Name + ":" + item2.Split(':')[1]);
                    }
                }
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