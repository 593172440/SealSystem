using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.IDAL
{
    /// <summary>
    /// 创建一个基类接口，并且要继承自models.BaseEntity，只能放它的子类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDAL<T> : IDisposable where T : Models.BaseEntity
    {
        Task AddAsync(T t,bool saved=true);
        Task EditAsync(T t,bool saved=true);
        Task RemoveAsync(int id, bool saved = true);
        Task RemoveAsync(T t, bool saved = true);
        Task SaveAsync();
        Task<T> GetOneAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllOrder(bool asc = true);
        IQueryable<T> GetAllByPage(int pageSize = 10, int pageIndex = 0);
        IQueryable<T> GetAllBypageOrder(int pageSzie = 10, int pageIndex = 0, bool asc = true);

    }
}
