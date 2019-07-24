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
        public async Task<ActionResult> Index()
        {
            var data = new BLL.SealUnitClassBLL();
            await data.RemoveAsync(1);
            return Content("删除成功");
        }
    }
}