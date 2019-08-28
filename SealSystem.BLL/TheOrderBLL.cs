using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 订单表(第二步:添加印章信息上面部分)
    /// </summary>
    public class TheOrderBLL
    {
        /// <summary>
        /// 增加一条订单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task Add(Models.TheOrder model)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据Id修改订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task Edit(int id,Models.TheOrder model)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                var data =await db.GetAll().FirstAsync(m => m.Id == id);
                data.ForTheRecordType = model.ForTheRecordType;
                data.SealInforNum = model.SealInforNum;
                data.SealMakingUnitInfor_Name = model.SealMakingUnitInfor_Name;
                data.TheRegistrationArea = model.TheRegistrationArea;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 获取订单的全部信息
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.TheOrder>> GetAll()
        {
            using (var db = new DAL.TheOrderDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        

    }
}
