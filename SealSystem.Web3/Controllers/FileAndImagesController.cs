using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SealSystem.Models;
using SealSystem.Web3.Filter;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class FileAndImagesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: FileAndImages
        public async Task<ActionResult> Index()
        {
            return View(await db.FileAndImages.ToListAsync());
        }

        // GET: FileAndImages/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileAndImage fileAndImage = await db.FileAndImages.FindAsync(id);
            if (fileAndImage == null)
            {
                return HttpNotFound();
            }
            return View(fileAndImage);
        }

        // GET: FileAndImages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FileAndImages/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,NamePath,SealInforNew_Id,Note,CreateTime,IsRemoved")] FileAndImage fileAndImage)
        {
            if (ModelState.IsValid)
            {
                db.FileAndImages.Add(fileAndImage);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(fileAndImage);
        }

        // GET: FileAndImages/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileAndImage fileAndImage = await db.FileAndImages.FindAsync(id);
            if (fileAndImage == null)
            {
                return HttpNotFound();
            }
            return View(fileAndImage);
        }

        // POST: FileAndImages/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,NamePath,SealInforNew_Id,Note,CreateTime,IsRemoved")] FileAndImage fileAndImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fileAndImage).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fileAndImage);
        }

        // GET: FileAndImages/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileAndImage fileAndImage = await db.FileAndImages.FindAsync(id);
            if (fileAndImage == null)
            {
                return HttpNotFound();
            }
            return View(fileAndImage);
        }

        // POST: FileAndImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FileAndImage fileAndImage = await db.FileAndImages.FindAsync(id);
            db.FileAndImages.Remove(fileAndImage);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult UpFileData(HttpPostedFileBase file)
        {
            string filePath="";
            //if (ModelState.IsValid)
            //{
                //string[] imageTypes = { "image/jpeg", "image/png" };
                //if (imageTypes.Any(m => m == file.ContentType))
                //{
                    filePath = $"/upLoads/{DateTime.Now.ToString("yyyyMMddhhmmss")}_{file.FileName}";
                    file.SaveAs(Request.MapPath("~" + filePath));
                    //return Content(filePath);
                //}
                //return new HttpStatusCodeResult(500, "格式不正确");
                //return Content("格式不正确");
            //}
            return Json(filePath);
        }
        public string ASJXUpFile(string name, string namePath, string SealInforNew_Id, string note)
        {
            db.FileAndImages.Add(new FileAndImage()
            {
                Name = name,
                NamePath = namePath,
                //SealInforNew_SealInforNum = sealInforNew_SealInforNum
            });
            db.SaveChanges();
            return "ok";
        }

    }
}
