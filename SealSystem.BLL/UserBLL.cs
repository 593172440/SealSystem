using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    public class UserBLL
    {
        public async Task AddAsync(Models.User user)
        {
            using (DAL.UserDAL db = new DAL.UserDAL())
            {
                db.Add
            }
        }
    }
}
