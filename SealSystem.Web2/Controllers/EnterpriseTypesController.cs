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

namespace SealSystem.Web2.Controllers
{
    public class EnterpriseTypesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: EnterpriseTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.EnterpriseTypes.ToListAsync());
        }

        // GET: EnterpriseTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnterpriseType enterpriseType = await db.EnterpriseTypes.FindAsync(id);
            if (enterpriseType == null)
            {
                return HttpNotFound();
            }
            return View(enterpriseType);
        }

        // GET: EnterpriseTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnterpriseTypes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,CreateTime,IsRemoved")] EnterpriseType enterpriseType)
        {
            if (ModelState.IsValid)
            {
                db.EnterpriseTypes.Add(enterpriseType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(enterpriseType);
        }

        // GET: EnterpriseTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnterpriseType enterpriseType = await db.EnterpriseTypes.FindAsync(id);
            if (enterpriseType == null)
            {
                return HttpNotFound();
            }
            return View(enterpriseType);
        }

        // POST: EnterpriseTypes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,CreateTime,IsRemoved")] EnterpriseType enterpriseType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enterpriseType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(enterpriseType);
        }

        // GET: EnterpriseTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnterpriseType enterpriseType = await db.EnterpriseTypes.FindAsync(id);
            if (enterpriseType == null)
            {
                return HttpNotFound();
            }
            return View(enterpriseType);
        }

        // POST: EnterpriseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EnterpriseType enterpriseType = await db.EnterpriseTypes.FindAsync(id);
            db.EnterpriseTypes.Remove(enterpriseType);
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
