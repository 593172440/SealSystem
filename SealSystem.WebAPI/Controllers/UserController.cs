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
    
    [EnableCors(origins:"*",methods:"*",headers:"*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
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
    }
}
