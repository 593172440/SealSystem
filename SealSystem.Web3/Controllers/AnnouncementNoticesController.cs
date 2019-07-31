using SealSystem.Models;
using SealSystem.Web3.Filter;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class AnnouncementNoticesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: AnnouncementNotices
        public async Task<ActionResult> Index()
        {
            return View(await db.AnnouncementNotices.ToListAsync());
        }

        // GET: AnnouncementNotices/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnnouncementNotice announcementNotice = await db.AnnouncementNotices.FindAsync(id);
            if (announcementNotice == null)
            {
                return HttpNotFound();
            }
            return View(announcementNotice);
        }

        // GET: AnnouncementNotices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnnouncementNotices/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Content,UserName,CreateTime,IsRemoved")] AnnouncementNotice announcementNotice)
        {
            if (ModelState.IsValid)
            {
                db.AnnouncementNotices.Add(announcementNotice);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(announcementNotice);
        }

        // GET: AnnouncementNotices/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnnouncementNotice announcementNotice = await db.AnnouncementNotices.FindAsync(id);
            if (announcementNotice == null)
            {
                return HttpNotFound();
            }
            return View(announcementNotice);
        }

        // POST: AnnouncementNotices/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Content,UserName,CreateTime,IsRemoved")] AnnouncementNotice announcementNotice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(announcementNotice).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(announcementNotice);
        }

        // GET: AnnouncementNotices/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnnouncementNotice announcementNotice = await db.AnnouncementNotices.FindAsync(id);
            if (announcementNotice == null)
            {
                return HttpNotFound();
            }
            return View(announcementNotice);
        }

        // POST: AnnouncementNotices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AnnouncementNotice announcementNotice = await db.AnnouncementNotices.FindAsync(id);
            db.AnnouncementNotices.Remove(announcementNotice);
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
