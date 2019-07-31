using SealSystem.Models;
using SealSystem.Web3.Filter;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class SealApprovalUnitInforsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealApprovalUnitInfors
        public async Task<ActionResult> Index()
        {
            return View(await db.SealApprovalUnitInfors.ToListAsync());
        }

        // GET: SealApprovalUnitInfors/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealApprovalUnitInfor sealApprovalUnitInfor = await db.SealApprovalUnitInfors.FindAsync(id);
            if (sealApprovalUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealApprovalUnitInfor);
        }

        // GET: SealApprovalUnitInfors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SealApprovalUnitInfors/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,ApprovalUnitCode,Name,LegelPerson,UnitAddress,Phone,TheZipCode,CreateTime,IsRemoved")] SealApprovalUnitInfor sealApprovalUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.SealApprovalUnitInfors.Add(sealApprovalUnitInfor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sealApprovalUnitInfor);
        }

        // GET: SealApprovalUnitInfors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealApprovalUnitInfor sealApprovalUnitInfor = await db.SealApprovalUnitInfors.FindAsync(id);
            if (sealApprovalUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealApprovalUnitInfor);
        }

        // POST: SealApprovalUnitInfors/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ApprovalUnitCode,Name,LegelPerson,UnitAddress,Phone,TheZipCode,CreateTime,IsRemoved")] SealApprovalUnitInfor sealApprovalUnitInfor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealApprovalUnitInfor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sealApprovalUnitInfor);
        }

        // GET: SealApprovalUnitInfors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealApprovalUnitInfor sealApprovalUnitInfor = await db.SealApprovalUnitInfors.FindAsync(id);
            if (sealApprovalUnitInfor == null)
            {
                return HttpNotFound();
            }
            return View(sealApprovalUnitInfor);
        }

        // POST: SealApprovalUnitInfors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealApprovalUnitInfor sealApprovalUnitInfor = await db.SealApprovalUnitInfors.FindAsync(id);
            db.SealApprovalUnitInfors.Remove(sealApprovalUnitInfor);
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
