using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using SealSystem.Models;
using SealSystem.Web3.Filter;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    /// <summary>
    /// 印章信息控制器
    /// </summary>
    [LoginFilter]
    public class SealInforNewsController : Controller
    {
        private SSContext db = new SSContext();
        private BLL.SealInforNewBLL sealDb = new BLL.SealInforNewBLL();
        // GET: SealInforNews
        public async Task<ActionResult> Index()
        {
            var sealInforNews = db.SealInforNews.Include(s => s.SealApprovalUnitInfor).Include(s => s.SealCategory).Include(s => s.SealMakingUnitInfor).Include(s => s.SealMaterial).Include(s => s.SealUseUnitInfor);
            return View(await sealInforNews.ToListAsync());
        }

        // GET: SealInforNews/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealInforNew sealInforNew = await db.SealInforNews.FindAsync(id);
            if (sealInforNew == null)
            {
                return HttpNotFound();
            }
            return View(sealInforNew);
        }

        // GET: SealInforNews/Create
        public ActionResult Create()
        {
            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "Name");
            //ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode_LegelPerson = new SelectList(db.SealApprovalUnitInfors, "Id", "LegelPerson");
            ViewBag.SealId = "120116" + sealDb.GetAllCount();
            //var sealList = db.SealCategorys.SqlQuery("select distinct name from sealcategories");
            //ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys,"Id","Name");
            ViewBag.SealCategory_Id_Code = db.SealCategorys.ToList();
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "Name");
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name");
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "Name");
            return View();
        }

        // POST: SealInforNews/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,SealInforNum,SealCategory_Id_Code,SealContent,ForeignLanguageContent,SealUseUnitInfor_Id_UnitNumber,EngravingType,SealMakingUnitInfor_Id_MakingUnitCode,SealMaterial_Id_Code,RegistrationCategory,SealShape,EngravingLevel,SealState,Attention,AttentionIdCard,Contact,Approval,ApprovalTime,SealApprovalUnitInfor_Id_ApprovalUnitCode,Note,MakeWay,TheProducer,CreateTime,IsRemoved")] SealInforNew sealInforNew)
        {
            if (ModelState.IsValid)
            {
                db.SealInforNews.Add(sealInforNew);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "Name", sealInforNew.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            //ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode_LegelPerson = new SelectList(db.SealApprovalUnitInfors, "Id", "LegelPerson");
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInforNew.SealCategory_Id_Code);
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "Name", sealInforNew.SealMakingUnitInfor_Id_MakingUnitCode);
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name", sealInforNew.SealMaterial_Id_Code);
            //ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name", sealInforNew.SealState_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "Name", sealInforNew.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInforNew);
        }

        // GET: SealInforNews/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealInforNew sealInforNew = await db.SealInforNews.FindAsync(id);
            if (sealInforNew == null)
            {
                return HttpNotFound();
            }
            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "ApprovalUnitCode", sealInforNew.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInforNew.SealCategory_Id_Code);
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "MakingUnitCode", sealInforNew.SealMakingUnitInfor_Id_MakingUnitCode);
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name", sealInforNew.SealMaterial_Id_Code);
            //ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name", sealInforNew.SealState_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInforNew.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInforNew);
        }

        // POST: SealInforNews/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,SealInforNum,SealCategory_Id_Code,SealContent,ForeignLanguageContent,SealUseUnitInfor_Id_UnitNumber,EngravingType,SealMakingUnitInfor_Id_MakingUnitCode,SealMaterial_Id_Code,RegistrationCategory,SealShape,EngravingLevel,SealState,Attention,AttentionIdCard,Contact,Approval,ApprovalTime,SealApprovalUnitInfor_Id_ApprovalUnitCode,Note,MakeWay,TheProducer,CreateTime,IsRemoved")] SealInforNew sealInforNew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealInforNew).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SealApprovalUnitInfor_Id_ApprovalUnitCode = new SelectList(db.SealApprovalUnitInfors, "Id", "ApprovalUnitCode", sealInforNew.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInforNew.SealCategory_Id_Code);
            ViewBag.SealMakingUnitInfor_Id_MakingUnitCode = new SelectList(db.SealMakingUnitInfors, "Id", "MakingUnitCode", sealInforNew.SealMakingUnitInfor_Id_MakingUnitCode);
            ViewBag.SealMaterial_Id_Code = new SelectList(db.SealMaterials, "Id", "Name", sealInforNew.SealMaterial_Id_Code);
            //ViewBag.SealState_Id_Code = new SelectList(db.SealStates, "Id", "Name", sealInforNew.SealState_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInforNew.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInforNew);
        }

        // GET: SealInforNews/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealInforNew sealInforNew = await db.SealInforNews.FindAsync(id);
            if (sealInforNew == null)
            {
                return HttpNotFound();
            }
            return View(sealInforNew);
        }

        // POST: SealInforNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealInforNew sealInforNew = await db.SealInforNews.FindAsync(id);
            db.SealInforNews.Remove(sealInforNew);
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
        public async Task<ActionResult> SealUserUnitInforList(string Name)
        {
            var unitInfors = db.UnitInfors.Include(s => s.Area).Include(s => s.SealUnitCategory).Include(s => s.SealUnitClass);
            SealUseUnitInfor list = await unitInfors.FirstOrDefaultAsync(m => m.Name == Name);
            if (list==null)
            {
                return Content("0");
            }
            else
            {
                
                return Content(JsonConvert.SerializeObject(list));
            }
        }
        /// <summary>
        /// 根据印章类型，获取印章规格
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public async Task<ActionResult> GetSealSpecification(string str)
        {
            //List<string> strs = new List<string>();
            List<Models.SealInforAndPng> png = new List<Models.SealInforAndPng>();
            var list = await db.SealCategorys.ToListAsync();
            foreach (var item in list)
            {
                if(item.Name==str)
                {
                    //strs.Add(item.SealSpecifications);
                    png.Add(new Models.SealInforAndPng { SealGuiGe = item.SealSpecifications, SealPng = item.TestImagePath });
                }
            }
            return Content(JsonConvert.SerializeObject(png));
        }
        public bool CreateSealList(string seal,string ars)
        {
            List<Models.SealInforNew1> s1= JsonConvert.DeserializeObject<List<Models.SealInforNew1>>(seal);
            Models.SealInforNew2 s2= JsonConvert.DeserializeObject<Models.SealInforNew2>(ars);
            
            return true;
        }
    }
}
