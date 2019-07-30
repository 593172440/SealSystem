using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SealSystem.Web3.Filter
{
    public class LoginFilterAttribute : AuthorizeAttribute
    {
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var cookieName = System.Web.HttpContext.Current.Request.Cookies.Get("loginName");
        //    if(cookieName==null)
        //    {
        //        filterContext.Result = new RedirectResult("/Login/index");
        //    }
        //}
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            //判断是否跳过授权过滤器
            //if (filterContext.ActionDescriptor.IsDefined(typeof(AllowHtmlAttribute), true) ||
            //    filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowHtmlAttribute), true))
            //{
            //    return;
            //}
            //判断登录情况
            if ((filterContext.HttpContext.Session["loginName"]==null))
            {
                //filterContext.Result = new RedirectResult("/Login/index");
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary()
                {
                    {"controller","Login" },
                    {"action","Index" }
                });
            }

        }
    }
}