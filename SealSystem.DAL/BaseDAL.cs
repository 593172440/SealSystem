using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SealSystem.DAL
{
    public class BaseDAL<T> : IDisposable where T : Models.BaseEntity, new()
    {
        public Models.SSContext _db = new Models.SSContext();
        public async Task AddAsync(T t, bool saved = true)
        {
            _db.Set<T>().Add(t);
            if (saved)
            {
                await _db.SaveChangesAsync();
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task EditAsync(T t, bool saved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            _db.Entry(t).State = EntityState.Modified;
            if (saved)
            {
                _db.Configuration.ValidateOnSaveEnabled = true;
                await _db.SaveChangesAsync();
            }
        }
        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().Where(m => !m.IsRemoved).AsNoTracking();
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
        public async Task RemoveAsync(int id, bool saved = true)
        {
            _db.Configuration.ValidateOnSaveEnabled = false;
            var data = GetAll().First(m => m.Id == id); 
            _db.Entry(data).State = EntityState.Modified;
            data.IsRemoved = true;
            if (saved)
            {
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
            }
        }

        public async Task RemoveAsync(T t, bool saved = true)
        {
            await RemoveAsync(t.Id, saved);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
            _db.Configuration.ValidateOnSaveEnabled = true;
        }
    }
}
