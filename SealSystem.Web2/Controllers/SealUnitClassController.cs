using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web2.Controllers
{
    public class SealUnitClassController : Controller
    {
        // GET: SealUnitClass
        public ActionResult Index()
        {
            //var data = new BLL.SealUnitClassBLL();
            //await data.RemoveAsync(1);
            //return Content("删除成功");
            return View();
        }
        
        public ActionResult Test()
        {
            

            return View();
        }
        public string Test2()
        {
            Models.DataJson data = new Models.DataJson()
            {
                code = 0,
                msg = "",
                count = 10,
                data = new List<Models.Student>()
                {
                    new Models.Student(){Id=1,Name="小红",Age=12 },
                    new Models.Student(){Id=1,Name="小红",Age=12 },
                    new Models.Student(){Id=1,Name="小红",Age=12 },
                    new Models.Student(){Id=1,Name="小红",Age=12 },
                    new Models.Student(){Id=1,Name="小红",Age=12 },
                    new Models.Student(){Id=1,Name="小红",Age=13 }
                }.ToArray()
            };
            string str = JsonConvert.SerializeObject(data);
            return str;
        }
    }
}