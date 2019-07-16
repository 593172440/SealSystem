using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SealSystem.DAL
{
    public class BaseDAL<T> : IDAL.IBaseDAL<T>, IDisposable where T : Models.BaseEntity, new()
    {
        private Models.SSContext db = new Models.SSContext();
        public void Add(T t, bool saved = true)
        {
            db.Set<T>().Add(t);
            if (saved)
            {
                db.SaveChanges();
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Edit(T t, bool saved = true)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            db.Entry(t).State = EntityState.Unchanged;
            if (saved)
            {

                db.Configuration.ValidateOnSaveEnabled = true;
                db.SaveChanges();
            }
        }
        public IQueryable<T> GetAll()
        {
            return db.Set<T>().Where(m => !m.IsRemoved).AsNoTracking();
        }
        public IQueryable<T> GetAllByPage(int pageSize = 10, int pageIndex = 0)
        {
            return GetAll().Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllBypageOrder(int pageSzie = 10, int pageIndex = 0, bool asc = true)
        {
            return GetAllOrder(asc).Skip(pageSzie * pageIndex).Take(pageSzie);
        }

        public IQueryable<T> GetAllOrder(bool asc = true)
        {
            if (asc)
            {
                return GetAll().OrderBy(m => m.CreateTime);
            }
            else
            {
                return GetAll().OrderByDescending(m => m.CreateTime);
            }
        }
        public T GetOne(int id)
        {
            return GetAll().First(m => m.Id == id);
        }
        public void Remove(int id, bool saved = true)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            var data = new T { Id = id };
            db.Entry(data).State = EntityState.Unchanged;
            data.IsRemoved = true;
            if (saved)
            {
                db.SaveChanges();
                db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public void Remove(T t, bool saved = true)
        {
            Remove(t.Id, saved);
        }

        public void Save()
        {
            db.SaveChanges();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
    }
}
