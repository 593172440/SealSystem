using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SealSystem.WebAPI.Filters
{
    /// <summary>
    /// 自定义过滤器,用来验证用户信息
    /// </summary>
    public class MyAuthAttribute : Attribute, IAuthorizationFilter
    {
        private IEnumerable<string> headers;

        public bool AllowMultiple => throw new NotImplementedException();

        public async Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            //尝试在headers头里面获取jwt加密串
            if(actionContext.Request.Headers.TryGetValues("token",out headers))
            {
                //如果获取到了headers里的token,就用jwt来解密
                string loginName = Tools.JWTTool.Decode(headers.First())["LoginName"].ToString();
                int userId = Convert.ToInt32(Tools.JWTTool.Decode(headers.First())["Id"]);
                //将用户名存入User.Identity.Name中
                (actionContext.ControllerContext.Controller as ApiController).User = new Models.Auth.ApplicationUser(userId, loginName);
                return await continuation();//成功则继续
            }
            //没有发现token时,报错
            return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);//401
        }
    }
}