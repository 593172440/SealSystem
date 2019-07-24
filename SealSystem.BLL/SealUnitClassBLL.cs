using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 单位分类
    /// </summary>
    public class SealUnitClassBLL
    {
        /// <summary>
        /// 创建单位分类
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        public async Task AddAsync(string name)
        {
            using (var db = new DAL.SealUnitClassDAL())
            {
                await db.AddAsync(new Models.SealUnitClass()
                {
                    Name = name
                });
            }
        }
        /// <summary>
        /// 修改单位分类
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task EditAsync(string name)
        {
            using (var db = new DAL.SealUnitClassDAL())
            {
                var data = new Models.SealUnitClass()
                {
                    Name = name
                };
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 获取所有单位分类
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.SealUnitClass>> GetAllAsync()
        {
            using (var db = new DAL.SealUnitClassDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据id删除单位分类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveAsync(int id)
        {
            using (var db = new DAL.SealUnitClassDAL())
            {
                await db.RemoveAsync(id);
            }

        }
    }
}
