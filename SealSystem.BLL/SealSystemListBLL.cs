using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SealSystem.BLL
{
    /// <summary>
    /// 所有印章系统所使用的下拉列表名单
    /// </summary>
    public class SealSystemListBLL
    {
        /// <summary>
        /// 增加一条新的下拉列表记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task AddAsync(Models.SealSystemList model)
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据id修改相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task EditAsync(int id, Models.SealSystemList model)
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.Id == id);
                data.Name = model.Name;
                data.Note = model.Note;
                data.Code = model.Code;
                data.CreateTime = DateTime.Now;
                data.Types = model.Types;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 根据id删除相应的数据(伪删除)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task DeleteAsync(int id)
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                await db.RemoveAsync(id);
            }
        }
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealSystemList>> GetAllAsync()
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Models.SealSystemList> GetOneForIdAsync(int id)
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                return await db.GetOneAsync(id);
            }
        }
        /// <summary>
        /// 根据name获取下拉列表数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<List<string>> GetForNameAsync(string name)
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                List<string> list = new List<string>();
                var data = await db.GetAll().Where(m => m.Name == name).ToListAsync();
                foreach (Models.SealSystemList item in data)
                {
                    list.Add(item.Types);
                }
                return list;
            }
        }
    }
}
