using SealSystem.Models;
using SealSystem.Web3.Filter;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SealSystem.Web3.Controllers
{
    [LoginFilter]
    public class MenuTablesController : Controller
    {
        private SSContext db = new SSContext();

        // GET: MenuTables
        public async Task<ActionResult> Index()
        {
            return View(await db.MenuTables.ToListAsync());
        }

        // GET: MenuTables/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuTable menuTable = await db.MenuTables.FindAsync(id);
            if (menuTable == null)
            {
                return HttpNotFound();
            }
            return View(menuTable);
        }

        // GET: MenuTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuTables/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,CodeId,Name,SuperiorCodeId,MenuPath,Add,Edit,Details,Delete,CreateTime,IsRemoved")] MenuTable menuTable)
        {
            if (ModelState.IsValid)
            {
                db.MenuTables.Add(menuTable);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(menuTable);
        }

        // GET: MenuTables/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuTable menuTable = await db.MenuTables.FindAsync(id);
            if (menuTable == null)
            {
                return HttpNotFound();
            }
            return View(menuTable);
        }

        // POST: MenuTables/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CodeId,Name,SuperiorCodeId,MenuPath,Add,Edit,Details,Delete,CreateTime,IsRemoved")] MenuTable menuTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuTable).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(menuTable);
        }

        // GET: MenuTables/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuTable menuTable = await db.MenuTables.FindAsync(id);
            if (menuTable == null)
            {
                return HttpNotFound();
            }
            return View(menuTable);
        }

        // POST: MenuTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MenuTable menuTable = await db.MenuTables.FindAsync(id);
            db.MenuTables.Remove(menuTable);
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
