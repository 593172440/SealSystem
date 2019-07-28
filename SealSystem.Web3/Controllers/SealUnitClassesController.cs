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
    public class SealUnitClassesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealUnitClasses
        public async Task<ActionResult> Index()
        {
            return View(await db.SealUnitClasses.ToListAsync());
        }

        // GET: SealUnitClasses/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUnitClass sealUnitClass = await db.SealUnitClasses.FindAsync(id);
            if (sealUnitClass == null)
            {
                return HttpNotFound();
            }
            return View(sealUnitClass);
        }

        // GET: SealUnitClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SealUnitClasses/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,CreateTime,IsRemoved")] SealUnitClass sealUnitClass)
        {
            if (ModelState.IsValid)
            {
                db.SealUnitClasses.Add(sealUnitClass);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sealUnitClass);
        }

        // GET: SealUnitClasses/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUnitClass sealUnitClass = await db.SealUnitClasses.FindAsync(id);
            if (sealUnitClass == null)
            {
                return HttpNotFound();
            }
            return View(sealUnitClass);
        }

        // POST: SealUnitClasses/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,CreateTime,IsRemoved")] SealUnitClass sealUnitClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealUnitClass).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sealUnitClass);
        }

        // GET: SealUnitClasses/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUnitClass sealUnitClass = await db.SealUnitClasses.FindAsync(id);
            if (sealUnitClass == null)
            {
                return HttpNotFound();
            }
            return View(sealUnitClass);
        }

        // POST: SealUnitClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealUnitClass sealUnitClass = await db.SealUnitClasses.FindAsync(id);
            db.SealUnitClasses.Remove(sealUnitClass);
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
