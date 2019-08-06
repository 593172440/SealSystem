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
    /// <summary>
    /// 印章类型规格控制器
    /// </summary>
    public class SealCategoriesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealCategories
        public async Task<ActionResult> Index()
        {
            return View(await db.SealCategorys.ToListAsync());
        }

        // GET: SealCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealCategory sealCategory = await db.SealCategorys.FindAsync(id);
            if (sealCategory == null)
            {
                return HttpNotFound();
            }
            return View(sealCategory);
        }

        // GET: SealCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SealCategories/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Code,SealSpecifications,TestImagePath,CreateTime,IsRemoved")] SealCategory sealCategory)
        {
            if (ModelState.IsValid)
            {
                db.SealCategorys.Add(sealCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sealCategory);
        }

        // GET: SealCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealCategory sealCategory = await db.SealCategorys.FindAsync(id);
            if (sealCategory == null)
            {
                return HttpNotFound();
            }
            return View(sealCategory);
        }

        // POST: SealCategories/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Code,SealSpecifications,TestImagePath,CreateTime,IsRemoved")] SealCategory sealCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sealCategory);
        }

        // GET: SealCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealCategory sealCategory = await db.SealCategorys.FindAsync(id);
            if (sealCategory == null)
            {
                return HttpNotFound();
            }
            return View(sealCategory);
        }

        // POST: SealCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealCategory sealCategory = await db.SealCategorys.FindAsync(id);
            db.SealCategorys.Remove(sealCategory);
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
