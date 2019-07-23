using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                await db.AddAsync(new Models.EnterpriseType()
                {
                    Name = name
                });
            }
        }
    }
}
