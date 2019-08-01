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

namespace SealSystem.Web3.Controllers
{
    public class FileAndImagesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: FileAndImages
        public async Task<ActionResult> Index()
        {
            var fileAndImages = db.FileAndImages.Include(f => f.SealInfor);
            return View(await fileAndImages.ToListAsync());
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
            ViewBag.SealInfor_Id = new SelectList(db.SealInfors, "Id", "SealInforNum");
            return View();
        }

        // POST: FileAndImages/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,NamePath,SealInfor_Id,Note,CreateTime,IsRemoved")] FileAndImage fileAndImage)
        {
            if (ModelState.IsValid)
            {
                db.FileAndImages.Add(fileAndImage);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SealInfor_Id = new SelectList(db.SealInfors, "Id", "SealInforNum", fileAndImage.SealInfor_Id);
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
            ViewBag.SealInfor_Id = new SelectList(db.SealInfors, "Id", "SealInforNum", fileAndImage.SealInfor_Id);
            return View(fileAndImage);
        }

        // POST: FileAndImages/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,NamePath,SealInfor_Id,Note,CreateTime,IsRemoved")] FileAndImage fileAndImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fileAndImage).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SealInfor_Id = new SelectList(db.SealInfors, "Id", "SealInforNum", fileAndImage.SealInfor_Id);
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
    }
}
