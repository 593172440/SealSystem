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
    /// 用户组
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/UserGroup")]
    public class UserGroupController : ApiController
    {
        /// <summary>
        /// 增加用户组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<IHttpActionResult> Post(Models.User.UserGroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                await BLL.UserGroupBLL.AddAsync(model.Name);
                return Ok(new Models.ResponseData() { Data = "增加成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 401, Data = "", ErrorMessage = "验证失败" });
            }
        }
        public async Task<SealSystem.Models.UserGroup> Get(string name)
        {
            return await BLL.UserGroupBLL.GetUserGroupOne(name);
        }
        /// <summary>
        /// 获取所有的用户组信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<SealSystem.Models.UserGroup>> GetAll()
        {
            return await BLL.UserGroupBLL.GetAll();
        }
        public async Task<IHttpActionResult> Delete(int id)
        {
            await BLL.UserGroupBLL.RemoveAsync(id);
            return Ok(new Models.ResponseData() { Data = "删除成功" });
        }
        public async Task<IHttpActionResult> Put(int id, string name)
        {
            await BLL.UserGroupBLL.EditAsync(id, name);
            return Ok(new Models.ResponseData() { Data = "修改成功" });
        }
    }
}
