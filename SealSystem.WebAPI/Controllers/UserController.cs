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
    [EnableCors(origins:"*",methods:"*",headers:"*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        /// <summary>
        /// 用户登录成功则返回token值
        /// </summary>
        /// <param name="model"></param>
        /// <returns>返回token值</returns>
        [Route("login"),HttpPost]
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
    }
}
