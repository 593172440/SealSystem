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
    public class SealMakingUnitInforsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealMakingUnitInfors
        public async Task<ActionResult> Index()
        {
            return View(await db.SealMakingUnitInfors.ToListAsync());
        }

        // GET: SealMakingUnitInfors/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealMakingUnitInfor sealMakingUnitInfor = await db.SealMakingUnitInfors.FindAsync(id);
            if (sealMakingUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealMakingUnitInfor);
        }

        // GET: SealMakingUnitInfors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SealMakingUnitInfors/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,MakingUnitCode,Name,EthnicMinoritiesName,EnglishName,LegelPerson,IdNumber,UnitAddress,Phone,TheZipCode,Contact,BusinessLicense,BusinessState,Remarks,CreateTime,IsRemoved,ContanctPhone")] SealMakingUnitInfor sealMakingUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.SealMakingUnitInfors.Add(sealMakingUnitInfor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sealMakingUnitInfor);
        }

        // GET: SealMakingUnitInfors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealMakingUnitInfor sealMakingUnitInfor = await db.SealMakingUnitInfors.FindAsync(id);
            if (sealMakingUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealMakingUnitInfor);
        }

        // POST: SealMakingUnitInfors/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,MakingUnitCode,Name,EthnicMinoritiesName,EnglishName,LegelPerson,IdNumber,UnitAddress,Phone,TheZipCode,Contact,BusinessLicense,BusinessState,Remarks,CreateTime,IsRemoved,ContanctPhone")] SealMakingUnitInfor sealMakingUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealMakingUnitInfor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sealMakingUnitInfor);
        }

        // GET: SealMakingUnitInfors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealMakingUnitInfor sealMakingUnitInfor = await db.SealMakingUnitInfors.FindAsync(id);
            if (sealMakingUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealMakingUnitInfor);
        }

        // POST: SealMakingUnitInfors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealMakingUnitInfor sealMakingUnitInfor = await db.SealMakingUnitInfors.FindAsync(id);
            db.SealMakingUnitInfors.Remove(sealMakingUnitInfor);
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
