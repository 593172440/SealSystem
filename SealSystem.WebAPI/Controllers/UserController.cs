using SealSystem.WebAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SealSystem.WebAPI.Controllers
{
    /// <summary>
    /// 用户
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        /// <summary>
        /// 用户登录成功则返回token值
        /// </summary>
        /// <param name="model"></param>
        /// <returns>返回token值</returns>
        [Route("login"), HttpPost]
        public IHttpActionResult Login(Models.User.UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                int id;
                bool isLogin = BLL.UserBLL.Login(model.UserName, model.UserPwd, out id);
                return Ok(new Models.ResponseData()
                {
                    Data = Tools.JWTTool.Encode(new Dictionary<string, object>()
                    {
                        { "UserName",model.UserName },
                        {"Id",model.Id }
                    })
                });
            }
            else
            {
                return Ok(new Models.ResponseData()
                {
                    code = 500,
                    Data = "",
                    ErrorMessage = "用户名或密码错误"
                });
            }
        }
        /// <summary>
        /// 查询:根据用户名获取相应的用户组信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [Route("getUserGroupForUserName"), HttpGet]
        public async Task<string> GetUserGroupForUserName(string userName)
        {
            return await BLL.UserBLL.GetUserGroupForUserName(userName);
        }
        /// <summary>
        /// 查询:根据用户名获取用户信息(postman Ok)
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [Route("getUserForUserName"), HttpGet]
        public async Task<Models.User.UserAll> GetUserForUserName(string userName)
        {
            var model = await BLL.UserBLL.GetUserForUserName(userName);
            Models.User.UserAll user = new Models.User.UserAll()
            {
                Approval = model.Approval,
                Attention = model.Attention,
                AttentionIdCard = model.AttentionIdCard,
                BusinessLicense = model.BusinessLicense,
                BusinessState = model.BusinessState,
                Contact = model.Contact,
                ContanctPhone = model.ContanctPhone,
                EnglishName = model.EnglishName,
                EntityName = model.EntityName,
                EthnicMinoritiesName = model.EthnicMinoritiesName,
                IdNumber = model.IdNumber,
                LegelPerson = model.LegelPerson,
                Note = model.Note,
                Phone = model.Phone,
                TheZipCode = model.TheZipCode,
                UnitAddress = model.UnitAddress,
                UnitCode = model.UnitCode,
                UserName=model.UserName,
                UserGroup_Id=model.UserGroup_Id,
                CreateTime=model.CreateTime,
                Id=model.Id
            };
            return user;
        }
        /// <summary>
        /// 更新:根据用户名更新用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("setUserForUserName"),HttpPost]
        public async Task<IHttpActionResult> SetUserForUserName(string userName, Models.User.UserAll model)
        {
            await BLL.UserBLL.SetUserForUserName(userName, new SealSystem.Models.User()
            {
                Approval = model.Approval,
                Attention = model.Attention,
                AttentionIdCard = model.AttentionIdCard,
                BusinessLicense = model.BusinessLicense,
                BusinessState = model.BusinessState,
                Contact = model.Contact,
                ContanctPhone = model.ContanctPhone,
                EnglishName = model.EnglishName,
                EntityName = model.EntityName,
                EthnicMinoritiesName = model.EthnicMinoritiesName,
                IdNumber = model.IdNumber,
                LegelPerson = model.LegelPerson,
                Note = model.Note,
                Phone = model.Phone,
                TheZipCode = model.TheZipCode,
                UnitAddress = model.UnitAddress,
                UnitCode = model.UnitCode,
            });
            return Ok(new Models.ResponseData() { code = 200, Data = "更新成功" });
        }
    }
}
