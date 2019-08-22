using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    public class UserGroupBLL
    {
        /// <summary>
        /// 添加用户组
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task AddAsync(string name)
        {
            using (var db = new DAL.UserGroupDAL())
            {
                await db.AddAsync(new Models.UserGroup()
                {
                    Name = name
                });
            }
        }
        /// <summary>
        /// 根据名称获取相应的用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task<Models.UserGroup> GetUserGroupOne(string name)
        {
            using (var db = new DAL.UserGroupDAL())
            {
                return await db.GetAll().FirstAsync(m => m.Name == name);
            }
        }
        /// <summary>
        /// 获取所有的用户组信息
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.UserGroup>> GetAll()
        {
            using (var db = new DAL.UserGroupDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据Id删除相应的用户组
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task RemoveAsync(int id)
        {
            using (var db = new DAL.UserGroupDAL())
            {
                await db.RemoveAsync(id);
            }
        }
        /// <summary>
        /// 根据id修改用户组名
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task EditAsync(int id,string name)
        {
            using (var db = new DAL.UserGroupDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.Id == id);
                data.Name = name;
                await db.EditAsync(data);
            }
        }
    }
}
