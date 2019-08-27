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
    /// 地区区域
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/Area")]
    public class AreaController : ApiController
    {
        /// <summary>
        /// 增加地区区域
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("add"),HttpGet]
        public async Task<IHttpActionResult> Add(string code, string name)
        {
            await BLL.AreaBLL.Add(code, name);
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("delete"), HttpGet]
        public async Task<IHttpActionResult> Delete(int id)
        {
            await BLL.AreaBLL.Delete(id);
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }
        /// <summary>
        /// 根据id修改地区区域
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("editForId"),HttpPost]
        public async Task<IHttpActionResult> SetArea(int id, Models.Area.AreaViewModel model)
        {
            await BLL.AreaBLL.SetArea(id, new SealSystem.Models.Area()
            {
                Code = model.Code,
                Name = model.Name
            });
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        [Route("all"),HttpGet]
        public async Task<List<Models.Area.AreaViewModel>> GetAll()
        {
            List<SealSystem.Models.Area> data = await BLL.AreaBLL.GetAll();
            List<Models.Area.AreaViewModel> dataViewModel = new List<Models.Area.AreaViewModel>();
            foreach (var item in data)
            {
                dataViewModel.Add(new Models.Area.AreaViewModel()
                {
                    Id=item.Id,
                    Code = item.Code,
                    Name = item.Name
                });
            }
            return dataViewModel;
        }
        /// <summary>
        /// 根据区域代码查找相应的数据
        /// </summary>
        /// <returns></returns>
        [Route("GetForCode"),HttpGet]
        public async Task<Models.Area.AreaViewModel> GetAllForCode(string code)
        {
            var data=await BLL.AreaBLL.GetAllForCode(code);
            return new Models.Area.AreaViewModel()
            {
                Code = data.Code,
                Name = data.Name
            };
        }
        /// <summary>
        /// 根据Id查找相应的数据
        /// </summary>
        /// <returns></returns>
        [Route("GetForId"),HttpGet]
        public async Task<Models.Area.AreaViewModel> GetAllForId(int id)
        {
            var data = await BLL.AreaBLL.GetAllForId(id);
            return new Models.Area.AreaViewModel()
            {
                Code = data.Code,
                Name = data.Name
            };
        }
    }
}
