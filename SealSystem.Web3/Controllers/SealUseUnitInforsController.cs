using SealSystem.Models;
using SealSystem.Web3.Filter;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class SealUseUnitInforsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealUseUnitInfors
        public async Task<ActionResult> Index()
        {
            return View(await db.SealUseUnitInfors.ToListAsync());
        }

        // GET: SealUseUnitInfors/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUseUnitInfor sealUseUnitInfor = await db.SealUseUnitInfors.FindAsync(id);
            if (sealUseUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealUseUnitInfor);
        }

        // GET: SealUseUnitInfors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SealUseUnitInfors/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UnitNumber,Name,EthnicMinoritiesName,EnglishName,LegelPerson,IdNumber,UnitAddress,Phone,IdNumbers,Note,UnitClassification,EnterpriseDocumentsType,TheUnitType,CreateTime,IsRemoved")] SealUseUnitInfor sealUseUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.SealUseUnitInfors.Add(sealUseUnitInfor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sealUseUnitInfor);
        }

        // GET: SealUseUnitInfors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUseUnitInfor sealUseUnitInfor = await db.SealUseUnitInfors.FindAsync(id);
            if (sealUseUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealUseUnitInfor);
        }

        // POST: SealUseUnitInfors/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UnitNumber,Name,EthnicMinoritiesName,EnglishName,LegelPerson,IdNumber,UnitAddress,Phone,IdNumbers,Note,UnitClassification,EnterpriseDocumentsType,TheUnitType,CreateTime,IsRemoved")] SealUseUnitInfor sealUseUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealUseUnitInfor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sealUseUnitInfor);
        }

        // GET: SealUseUnitInfors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealUseUnitInfor sealUseUnitInfor = await db.SealUseUnitInfors.FindAsync(id);
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
            SealUseUnitInfor sealUseUnitInfor = await db.SealUseUnitInfors.FindAsync(id);
            db.SealUseUnitInfors.Remove(sealUseUnitInfor);
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
