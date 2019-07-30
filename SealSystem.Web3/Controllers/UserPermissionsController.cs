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
    public class UserPermissionsController : Controller
    {
        private SSContext db = new SSContext();

        // GET: UserPermissions
        public async Task<ActionResult> Index()
        {
            var userPermissions = db.UserPermissions.Include(u => u.MenuTable).Include(u => u.User);
            return View(await userPermissions.ToListAsync());
        }

        // GET: UserPermissions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPermissions userPermissions = await db.UserPermissions.FindAsync(id);
            if (userPermissions == null)
            {
                return HttpNotFound();
            }
            return View(userPermissions);
        }

        // GET: UserPermissions/Create
        public ActionResult Create()
        {
            ViewBag.Menu_Id = new SelectList(db.MenuTables, "Id", "Name");
            ViewBag.User_Id = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: UserPermissions/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,User_Id,Menu_Id,CreateTime,IsRemoved")] UserPermissions userPermissions)
        {
            if (ModelState.IsValid)
            {
                db.UserPermissions.Add(userPermissions);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Menu_Id = new SelectList(db.MenuTables, "Id", "Name", userPermissions.Menu_Id);
            ViewBag.User_Id = new SelectList(db.Users, "Id", "UserName", userPermissions.User_Id);
            return View(userPermissions);
        }

        // GET: UserPermissions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPermissions userPermissions = await db.UserPermissions.FindAsync(id);
            if (userPermissions == null)
            {
                return HttpNotFound();
            }
            ViewBag.Menu_Id = new SelectList(db.MenuTables, "Id", "Name", userPermissions.Menu_Id);
            ViewBag.User_Id = new SelectList(db.Users, "Id", "UserName", userPermissions.User_Id);
            return View(userPermissions);
        }

        // POST: UserPermissions/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,User_Id,Menu_Id,CreateTime,IsRemoved")] UserPermissions userPermissions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userPermissions).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Menu_Id = new SelectList(db.MenuTables, "Id", "Name", userPermissions.Menu_Id);
            ViewBag.User_Id = new SelectList(db.Users, "Id", "UserName", userPermissions.User_Id);
            return View(userPermissions);
        }

        // GET: UserPermissions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPermissions userPermissions = await db.UserPermissions.FindAsync(id);
            if (userPermissions == null)
            {
                return HttpNotFound();
            }
            return View(userPermissions);
        }

        // POST: UserPermissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UserPermissions userPermissions = await db.UserPermissions.FindAsync(id);
            db.UserPermissions.Remove(userPermissions);
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
