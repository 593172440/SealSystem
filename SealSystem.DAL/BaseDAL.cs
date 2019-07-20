using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SealSystem.DAL
{
    public class BaseDAL<T> :IDisposable where T : Models.BaseEntity, new()
    {
        private Models.SSContext db = new Models.SSContext();
        public async Task AddAsync(T t, bool saved = true)
        {
            db.Set<T>().Add(t);
            if (saved)
            {
                await db.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public async Task EditAsync(T t, bool saved = true)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            db.Entry(t).State = EntityState.Modified;
            if (saved)
            {
                db.Configuration.ValidateOnSaveEnabled = true;
                await db.SaveChangesAsync();
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
        public async Task<T> GetOneAsync(int id)
        {
            return await GetAll().FirstAsync(m => m.Id == id);
        }
        public async void RemoveAsync(int id, bool saved = true)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            var data = new T { Id = id };
            db.Entry(data).State = EntityState.Modified;
            data.IsRemoved = true;
            if (saved)
            {
                await db.SaveChangesAsync();
                db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public void Remove(T t, bool saved = true)
        {
            RemoveAsync(t.Id, saved);
        }

        public async Task Save()
        {
            await db.SaveChangesAsync();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
    }
}
