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
    /// 所有印章系统所使用的下拉列表名单
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/SealSystemList")]
    public class SealSystemListController : ApiController
    {
        /// <summary>
        /// 增加一条新的下拉列表记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("add"),HttpPost]
        public async Task Add(Models.SealSystemList.SealSystemListViewModel model)
        {
            SealSystem.Models.SealSystemList data = new SealSystem.Models.SealSystemList()
            {
                Code = model.Code,
                Name = model.Name,
                Note = model.Note,
                Types=model.Types
            };
            await BLL.SealSystemListBLL.Add(data);
        }
    }
}
