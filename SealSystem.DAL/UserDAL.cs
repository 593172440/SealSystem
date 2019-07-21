using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SealSystem.DAL
{
    public class UserDAL:BaseDAL<Models.User>
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public async Task AddUserAsync(string name,string pwd)
        {
            using (DAL.UserDAL db = new UserDAL())
            {
                await db.AddAsync(new Models.User() { UserName = name, UserPwd = pwd });
            }
        }
    }
}
