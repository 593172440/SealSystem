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
        public static async Task Add(Models.SealSystemList model)
        {
            using (var db = new DAL.SealSystemListDAL())
            {
                await db.AddAsync(model);

            }
        }
    }
}
