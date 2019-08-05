using SealSystem.Models;
using SealSystem.Web3.Filter;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class SealSpecificationsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: SealSpecifications
        public async Task<ActionResult> Index()
        {
            return View(await db.SealSpecifications.ToListAsync());
        }

        // GET: SealSpecifications/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealSpecification sealSpecification = await db.SealSpecifications.FindAsync(id);
            if (sealSpecification == null)
            {
                return HttpNotFound();
            }
            return View(sealSpecification);
        }

        // GET: SealSpecifications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SealSpecifications/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,SealSpecifications,TestImagePath,SealCategory_Id,CreateTime,IsRemoved")] SealSpecification sealSpecification)
        {
            if (ModelState.IsValid)
            {
                db.SealSpecifications.Add(sealSpecification);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sealSpecification);
        }

        // GET: SealSpecifications/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealSpecification sealSpecification = await db.SealSpecifications.FindAsync(id);
            if (sealSpecification == null)
            {
                return HttpNotFound();
            }
            return View(sealSpecification);
        }

        // POST: SealSpecifications/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,SealSpecifications,TestImagePath,SealCategory_Id,CreateTime,IsRemoved")] SealSpecification sealSpecification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sealSpecification).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sealSpecification);
        }

        // GET: SealSpecifications/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SealSpecification sealSpecification = await db.SealSpecifications.FindAsync(id);
            if (sealSpecification == null)
            {
                return HttpNotFound();
            }
            return View(sealSpecification);
        }

        // POST: SealSpecifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SealSpecification sealSpecification = await db.SealSpecifications.FindAsync(id);
            db.SealSpecifications.Remove(sealSpecification);
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
