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
using Newtonsoft.Json;

namespace SealSystem.Web3.Controllers
{
    public class SealInforNewsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealInforNews
        public async Task<ActionResult> Index()
        {
            var sealInforNews = db.SealInforNews.Include(s => s.SealCategory).Include(s => s.SealUseUnitInfor);
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
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name");
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber");
            ViewBag.SealCategory_Id_Code = db.SealCategorys.ToList();
            return View();
        }

        // POST: SealInforNews/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,SealInforNum,SealUseUnitInfor_Id_UnitNumber,SealCategory_Id_Code,SealContent,ForeignLanguageContent,SealMaterial,RegistrationCategory,SealShape,EngravingType,EngravingLevel,SealState,MakeWay,TheProducer,Note,CreateTime,IsRemoved")] SealInforNew sealInforNew)
        {
            if (ModelState.IsValid)
            {
                db.SealInforNews.Add(sealInforNew);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInforNew.SealCategory_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInforNew.SealUseUnitInfor_Id_UnitNumber);
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
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInforNew.SealCategory_Id_Code);
            ViewBag.SealUseUnitInfor_Id_UnitNumber = new SelectList(db.UnitInfors, "Id", "UnitNumber", sealInforNew.SealUseUnitInfor_Id_UnitNumber);
            return View(sealInforNew);
        }

        // POST: SealInforNews/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,SealInforNum,SealUseUnitInfor_Id_UnitNumber,SealCategory_Id_Code,SealContent,ForeignLanguageContent,SealMaterial,RegistrationCategory,SealShape,EngravingType,EngravingLevel,SealState,MakeWay,TheProducer,Note,CreateTime,IsRemoved")] SealInforNew sealInforNew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealInforNew).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.SealCategory_Id_Code = new SelectList(db.SealCategorys, "Id", "Name", sealInforNew.SealCategory_Id_Code);
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
        /// <summary>
        /// 根据单位名称获取使用单位信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<ActionResult> SealUserUnitInforList(string name)
        {

            SealUseUnitInfor _sealUserUnitInfor = await BLL.SealUseUnitInforBLL.GetOneForName(name);
            if (_sealUserUnitInfor == null)
            {
                return Content("0");
            }
            else
            {

                return Content(JsonConvert.SerializeObject(_sealUserUnitInfor));
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
                if (item.Name == str)
                {
                    //strs.Add(item.SealSpecifications);
                    png.Add(new Models.SealInforAndPng { SealGuiGe = item.SealSpecifications, SealPng = item.TestImagePath });
                }
            }
            return Content(JsonConvert.SerializeObject(png));
        }
        /// <summary>
        /// 向数据库插入印章信息
        /// </summary>
        /// <param name="seal"></param>
        /// <param name="ars"></param>
        /// <returns></returns>
        public async Task<bool> CreateSealList(string seal, string ars)
        {
            //List<Models.SealInforNew1> s1 = JsonConvert.DeserializeObject<List<Models.SealInforNew1>>(seal);
            //Models.SealInforNew2 s2 = JsonConvert.DeserializeObject<Models.SealInforNew2>(ars);
            //SealSystem.BLL.SealCategoriesBLL sc = new BLL.SealCategoriesBLL();

            //SealSystem.Models.SealInforNew list = new SealInforNew();
            //List<SealSystem.Models.SealInforNew> listss = new List<SealInforNew>();
            //foreach (var item in s1)
            //{
            //    list.Approval = s2.Approval;
            //    list.ApprovalTime = Convert.ToDateTime(s2.ApprovalTime);
            //    list.Attention = s2.Attention;
            //    list.AttentionIdCard = s2.AttentionIdCard;
            //    //list.Contact = item.SealContent;
            //    list.EngravingLevel = item.EngravingLevel;
            //    list.EngravingType = item.EngravingType;
            //    list.ForeignLanguageContent = s2.ForeignLanguageContent;
            //    list.Note = item.Note;
            //    list.RegistrationCategory = item.RegistrationCategory;
            //    list.SealApprovalUnitInfor_Id_ApprovalUnitCode = Convert.ToInt32(s2.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            //    list.SealCategory_Id_Code = sc.GetSelected(item.SealCategory_Id_Code, item.SealSpecification);
            //    //Convert.ToInt32(item.SealCategory_Id_Code);//这里要查询数据
            //    list.SealContent = item.SealContent;
            //    list.SealInforNum = item.SealInforNum;
            //    list.SealMakingUnitInfor_Id_MakingUnitCode = Convert.ToInt32(s2.SealMakingUnitInfor_Id_MakingUnitCode);
            //    list.SealMaterial_Id_Code = Convert.ToInt32(item.SealMaterial_Id_Code);
            //    list.SealShape = item.SealShape;
            //    list.SealState = s2.SealState;

            //    if (!string.IsNullOrEmpty(s2.SealUseUnitInfor_Id_UnitNumber))
            //    {
            //        var unitInfors = db.UnitInfors.Include(s => s.Area).Include(s => s.SealUnitCategory).Include(s => s.SealUnitClass);
            //        SealUseUnitInfor _sealUserUnitInfor = await unitInfors.FirstOrDefaultAsync(m => m.Name == s2.SealUseUnitInfor_Id_UnitNumber);
            //        list.SealUseUnitInfor_Id_UnitNumber = _sealUserUnitInfor.Id;
            //    }


            //    // Convert.ToInt32(s2.SealUseUnitInfor_Id_UnitNumber);//这里也要查询数据
            //    listss.Add(list);
            //}
            //try
            //{
            //    foreach (var item in listss)
            //    {
            //        await sealDb.AddAsync(item);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}



            return true;
        }
    }
}
