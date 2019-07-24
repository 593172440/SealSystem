using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SealSystem.BLL
{
    public class EnterpriseTypeBLL
    {
        /// <summary>
        /// 添加企业类型
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task CreateEnterpriseType(string name)
        {
            using (var db = new DAL.EnterpriseTypeDAL())
            {
                await db.AddAsync(new Models.SealUnitCategory()
                {
                    Name = name
                });
            }
        }
        /// <summary>
        /// 根据id修改企业类型
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">要修改的类型</param>
        /// <returns></returns>
        public async Task Edit(int id,string name)
        {
            using (var db = new DAL.EnterpriseTypeDAL())
            {
                var dbData= db.GetAll().First(m => m.Id == id);
                dbData.Name = name;
                await db.EditAsync(dbData);
            }
        }
        /// <summary>
        /// 获取所有的企业类型列表
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.SealUnitCategory>> GetAllAsync()
        {
            using (var db = new DAL.EnterpriseTypeDAL())
            {
               return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 删除企业类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            using (var db = new DAL.EnterpriseTypeDAL())
            {
                await db.RemoveAsync(id);
            }
        }
    }
}
