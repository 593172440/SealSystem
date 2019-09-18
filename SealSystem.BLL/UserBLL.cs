using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    public class UserBLL
    {
       /// <summary>
       /// 增加用户
       /// </summary>
       /// <param name="user"></param>
       /// <param name="pwd"></param>
       /// <returns></returns>
        public async Task AddAsync(string user,string pwd,string entityName)
        {
            using (DAL.UserDAL db = new DAL.UserDAL())
            {
                await db.AddAsync(new Models.User() {
                    UserName=user,
                    UserPwd=pwd,
                    EntityName=entityName
                });
            }
        }
        public async Task<Models.User> GetUserOne(string userName)
        {
            using (var db = new DAL.UserDAL())
            {
                return await db.GetAll().FirstAsync(m => m.UserName == userName);
            }
        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.User>> GetAllAsync()
        {
            using (var db = new DAL.UserDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据Id删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveAsync(int id)
        {
            using (var db = new DAL.UserDAL())
            {
                await db.RemoveAsync(id);
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="user"></param>
        /// <param name="oldPwd"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public async Task EditAsync(string user,string oldPwd,string newPwd)
        {
            using (var db = new DAL.UserDAL())
            {
                var userData= await db.GetAll().FirstAsync(m => m.UserName == user);
                userData.UserPwd = newPwd;
                await db.EditAsync(userData);
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static async Task<bool> Login(string user,string pwd)
        {
            using (var db = new DAL.UserDAL())
            {
                return await db.GetAll().AnyAsync(m => m.UserName == user && m.UserPwd == pwd);
            }

        }
        /// <summary>
        /// 登录并返回id
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Login(string user, string pwd, out int id)
        {
            using (var db = new DAL.UserDAL())
            {
                var emp = db.GetAll().FirstOrDefaultAsync(m => m.UserName == user && m.UserPwd == pwd);
                emp.Wait();
                if (emp.Result == null)
                {
                    id = -1;
                    return false;
                }
                else
                {
                    id = emp.Id;
                    return true;
                }
            }
        }
        /// <summary>
        /// 查询:根据用户名获取相应的用户组信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static async Task<string> GetUserGroupForUserName(string userName)
        {
            using (var db = new DAL.UserDAL())
            {
                return (await db._db.Users.Include(s => s.UserGroup).FirstAsync(m => m.UserName == userName)).UserGroup.Name;
            }
        }
        /// <summary>
        /// 查询:根据用户名获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static async Task<Models.User> GetUserForUserName(string userName)
        {
            using (var db = new DAL.UserDAL())
            {
                return await db.GetAll().FirstAsync(s => s.UserName == userName);
            }
        }
        /// <summary>
        /// 更新:根据用户名更新用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task SetUserForUserName(string userName,Models.User model)
        {
            using (var db = new DAL.UserDAL())
            {
                var data= await db.GetAll().FirstAsync(s => s.UserName == userName);
                data.Approval = model.Approval;
                data.Attention = model.Attention;
                data.AttentionIdCard = model.AttentionIdCard;
                data.BusinessLicense = model.BusinessLicense;
                data.BusinessState = model.BusinessState;
                data.Contact = model.Contact;
                data.ContanctPhone = model.ContanctPhone;
                data.EnglishName = model.EnglishName;
                data.EntityName = model.EntityName;
                data.EthnicMinoritiesName = model.EthnicMinoritiesName;
                data.IdNumber = model.IdNumber;
                data.LegelPerson = model.LegelPerson;
                data.Note = model.Note;
                data.Phone = model.Phone;
                data.TheZipCode = model.TheZipCode;
                data.UnitAddress = model.UnitAddress;
                data.UnitCode = model.UnitCode;
                await db.EditAsync(data);
            }
        }
    }
}
