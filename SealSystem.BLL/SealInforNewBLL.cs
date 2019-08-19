using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章信息
    /// </summary>
    public class SealInforNewBLL
    {
        /// <summary>
        /// 获取数据库中全部数据
        /// </summary>
        /// <returns></returns>
        public string GetAllCount()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                int str = db.GetAll().Count()+10;//100
                string strs = str.ToString();
                int j = str.ToString().Length;
                int k = 7 - j;
                if (j < 7)
                {
                    for (int i = 0; i < k; i++)
                    {
                        strs = "0" + strs;
                    }
                }
                return strs;
            }
        }
        public async Task AddAsync(Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                await db.AddAsync(model);
            }

        }
    }
}
