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
    public class SealInforsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealInfors
        public async Task<ActionResult> Index()
        {
            var sealInfors = db.SealInfors.Include(s => s.SealApprovalUnitInfor).Include(s => s.SealCategory).Include(s => s.SealImageData).Include(s => s.SealMakingUnitInfor).Include(s => s.SealMaterial).Include(s => s.SealState).Include(s => s.SealUseUnitInfor);
            return View(await sealInfors.ToListAsync());
        }

        // GET: SealInfors/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealInfor sealInfor = await db.SealInfors.FindAsync(id);
            if (sealInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealInfor);
        }

        // GET: SealInfors/Create
        public ActionResult Create()
        {
            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "ApprovalUnitCode");
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name");
            ViewBag.SealImageData_Id = new SelectList(db.SealImageDatas, "Id", "ImageWidth");
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "MakingUnitCode");
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name");
            ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name");
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber");
            return View();
        }

        // POST: SealInfors/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,SealInforNum,SealName,SealState_Id_Code,SealUseUnitInfor_Id_UnitNumber,SealApprovalUnitInfor_Id_ApprovalUnitCode,SealMakingUnitInfor_Id_MakingUnitCode,SealCategory_Id_Code,SealMaterial_Id_Code,ManyInstructions,Attention,AttentionIdCard,Approval,ApprovalTime,UndertakeTime,MakingTime,DeliveryTime,ScrapTime,HandTime,LossTime,LastAnnualTime,SealImageData_Id,SealSpecification,SealShape,EngravingType,EngravingLevel,CreateTime,IsRemoved")] SealInfor sealInfor)
        {
            if (ModelState.IsValid)
            {
                db.SealInfors.Add(sealInfor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "ApprovalUnitCode", sealInfor.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInfor.SealCategory_Id_Code);
            ViewBag.SealImageData_Id = new SelectList(db.SealImageDatas, "Id", "ImageWidth", sealInfor.SealImageData_Id);
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "MakingUnitCode", sealInfor.SealMakingUnitInfor_Id_MakingUnitCode);
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name", sealInfor.SealMaterial_Id_Code);
            ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name", sealInfor.SealState_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInfor.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInfor);
        }

        // GET: SealInfors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealInfor sealInfor = await db.SealInfors.FindAsync(id);
            if (sealInfor == null)
            {
                return HttpNotFound();
            }
            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "ApprovalUnitCode", sealInfor.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInfor.SealCategory_Id_Code);
            ViewBag.SealImageData_Id = new SelectList(db.SealImageDatas, "Id", "ImageWidth", sealInfor.SealImageData_Id);
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "MakingUnitCode", sealInfor.SealMakingUnitInfor_Id_MakingUnitCode);
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name", sealInfor.SealMaterial_Id_Code);
            ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name", sealInfor.SealState_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInfor.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInfor);
        }

        // POST: SealInfors/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,SealInforNum,SealName,SealState_Id_Code,SealUseUnitInfor_Id_UnitNumber,SealApprovalUnitInfor_Id_ApprovalUnitCode,SealMakingUnitInfor_Id_MakingUnitCode,SealCategory_Id_Code,SealMaterial_Id_Code,ManyInstructions,Attention,AttentionIdCard,Approval,ApprovalTime,UndertakeTime,MakingTime,DeliveryTime,ScrapTime,HandTime,LossTime,LastAnnualTime,SealImageData_Id,SealSpecification,SealShape,EngravingType,EngravingLevel,CreateTime,IsRemoved")] SealInfor sealInfor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealInfor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "ApprovalUnitCode", sealInfor.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInfor.SealCategory_Id_Code);
            ViewBag.SealImageData_Id = new SelectList(db.SealImageDatas, "Id", "ImageWidth", sealInfor.SealImageData_Id);
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "MakingUnitCode", sealInfor.SealMakingUnitInfor_Id_MakingUnitCode);
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name", sealInfor.SealMaterial_Id_Code);
            ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name", sealInfor.SealState_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInfor.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInfor);
        }

        // GET: SealInfors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealInfor sealInfor = await db.SealInfors.FindAsync(id);
            if (sealInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealInfor);
        }

        // POST: SealInfors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealInfor sealInfor = await db.SealInfors.FindAsync(id);
            db.SealInfors.Remove(sealInfor);
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
