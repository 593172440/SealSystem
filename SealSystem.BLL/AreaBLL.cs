using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SealSystem.BLL
{
    /// <summary>
    /// 地区区域
    /// </summary>
    public class AreaBLL
    {
        /// <summary>
        /// 增加地区区域
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task Add(string code,string name)
        {
            using (var db = new DAL.AreaDAL())
            {
                await db.AddAsync(new Models.Area()
                {
                    Code = code,
                    Name = name
                });
            }
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task Delete(int id)
        {
            using (var db = new DAL.AreaDAL())
            {
                await db.RemoveAsync(id);
            }
        }
        /// <summary>
        /// 根据id修改地区区域
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task SetArea(int id,Models.Area model)
        {
            using (var db = new DAL.AreaDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.Id == id);
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.Area>> GetAll()
        {
            using (var db = new DAL.AreaDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据区域代码查找相应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.Area> GetAllForCode(string code)
        {
            using (var db = new DAL.AreaDAL())
            {
                return await db.GetAll().FirstAsync(m => m.Code == code);
            }
        }
        /// <summary>
        /// 根据Id查找相应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.Area> GetAllForId(int id)
        {
            using (var db = new DAL.AreaDAL())
            {
                return await db.GetOneAsync(id);
            }
        }
    }
}
