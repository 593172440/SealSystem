using SealSystem.Web3.Filter;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class FileAndImageController : Controller
    {
        // GET: FileAndImage
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(HttpPostedFileBase file)
        {
            
            if (ModelState.IsValid)
            {
                string[] imageTypes = { "image/jpeg", "image/png" };
                if (imageTypes.Any(m => m == file.ContentType))
                {
                    string filePath = $"/upLoads/{DateTime.Now.ToString("yyyyMMddhhmmss")}_{file.FileName}";
                    file.SaveAs(Request.MapPath("~" + filePath));
                    //return Content(filePath);
                }
                //return new HttpStatusCodeResult(500, "格式不正确");
                return Content("格式不正确");
                
            }
                return View();
        }
    }
}