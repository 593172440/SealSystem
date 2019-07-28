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
    public class SealUseUnitInforsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealUseUnitInfors
        public async Task<ActionResult> Index()
        {
            var unitInfors = db.UnitInfors.Include(s => s.Area).Include(s => s.SealUnitCategory).Include(s => s.SealUnitClass);
            return View(await unitInfors.ToListAsync());
        }

        // GET: SealUseUnitInfors/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUseUnitInfor sealUseUnitInfor = await db.UnitInfors.FindAsync(id);
            if (sealUseUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealUseUnitInfor);
        }

        // GET: SealUseUnitInfors/Create
        public ActionResult Create()
        {
            ViewBag.Area_Id = new SelectList(db.Areas, "Id", "Code");
            ViewBag.EnterpriseType_Id = new SelectList(db.SealUnitCategorys, "Id", "Name");
            ViewBag.SealUnitClass_Id = new SelectList(db.SealUnitClasses, "Id", "Name");
            return View();
        }

        // POST: SealUseUnitInfors/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UnitNumber,Name,EthnicMinoritiesName,EnglishName,EnterpriseType_Id,VoiceQueryPassword,LegelPerson,IdNumber,UnitAddress,Phone,TheZipCode,SealUnitClass_Id,EnterpriseDocumentsType,IdNumbers,Area_Id,CreateTime,IsRemoved")] SealUseUnitInfor sealUseUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.UnitInfors.Add(sealUseUnitInfor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Area_Id = new SelectList(db.Areas, "Id", "Code", sealUseUnitInfor.Area_Id);
            ViewBag.EnterpriseType_Id = new SelectList(db.SealUnitCategorys, "Id", "Name", sealUseUnitInfor.EnterpriseType_Id);
            ViewBag.SealUnitClass_Id = new SelectList(db.SealUnitClasses, "Id", "Name", sealUseUnitInfor.SealUnitClass_Id);
            return View(sealUseUnitInfor);
        }

        // GET: SealUseUnitInfors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUseUnitInfor sealUseUnitInfor = await db.UnitInfors.FindAsync(id);
            if (sealUseUnitInfor == null)
            {
                return HttpNotFound();
            }
            ViewBag.Area_Id = new SelectList(db.Areas, "Id", "Code", sealUseUnitInfor.Area_Id);
            ViewBag.EnterpriseType_Id = new SelectList(db.SealUnitCategorys, "Id", "Name", sealUseUnitInfor.EnterpriseType_Id);
            ViewBag.SealUnitClass_Id = new SelectList(db.SealUnitClasses, "Id", "Name", sealUseUnitInfor.SealUnitClass_Id);
            return View(sealUseUnitInfor);
        }

        // POST: SealUseUnitInfors/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UnitNumber,Name,EthnicMinoritiesName,EnglishName,EnterpriseType_Id,VoiceQueryPassword,LegelPerson,IdNumber,UnitAddress,Phone,TheZipCode,SealUnitClass_Id,EnterpriseDocumentsType,IdNumbers,Area_Id,CreateTime,IsRemoved")] SealUseUnitInfor sealUseUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealUseUnitInfor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Area_Id = new SelectList(db.Areas, "Id", "Code", sealUseUnitInfor.Area_Id);
            ViewBag.EnterpriseType_Id = new SelectList(db.SealUnitCategorys, "Id", "Name", sealUseUnitInfor.EnterpriseType_Id);
            ViewBag.SealUnitClass_Id = new SelectList(db.SealUnitClasses, "Id", "Name", sealUseUnitInfor.SealUnitClass_Id);
            return View(sealUseUnitInfor);
        }

        // GET: SealUseUnitInfors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUseUnitInfor sealUseUnitInfor = await db.UnitInfors.FindAsync(id);
            if (sealUseUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealUseUnitInfor);
        }

        // POST: SealUseUnitInfors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealUseUnitInfor sealUseUnitInfor = await db.UnitInfors.FindAsync(id);
            db.UnitInfors.Remove(sealUseUnitInfor);
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
