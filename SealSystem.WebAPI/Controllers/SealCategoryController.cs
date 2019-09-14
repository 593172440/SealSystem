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
    /// 印章类型规格表(印章类型,印章规格,测试印章图片地址)
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/Area")]
    public class SealCategoryController : ApiController
    {
        /// <summary>
        /// 根据id获取测试印章图片地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("testImagePathForId"),HttpGet]
        public async Task<string> GetTestImagePathForId(int id)
        {
            string data=await BLL.SealCategoriesBLL.GetTestImagePathForId(id);
            return "/images/SealImages/" + data;
        }
    }
}
