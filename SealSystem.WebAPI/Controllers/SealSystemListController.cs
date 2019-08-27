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
    /// 所有印章系统所使用的下拉列表名单(Postman测试通过)
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
        [Route("add"), HttpPost]
        public async Task<IHttpActionResult> AddAsync(Models.SealSystemList.SealSystemListViewModel model)
        {
            if(ModelState.IsValid)
            {
                SealSystem.Models.SealSystemList data = new SealSystem.Models.SealSystemList()
                {
                    Code = model.Code,
                    Name = model.Name,
                    Note = model.Note,
                    Types = model.Types
                };
                await BLL.SealSystemListBLL.AddAsync(data);
                return Ok(new Models.ResponseData() { code = 200, Data = "增加成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 200,ErrorMessage="增加失败" });
            }
            
        }
        /// <summary>
        /// 根据id修改相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("edit"), HttpPost]
        public async Task<IHttpActionResult> EditAsync(int id, Models.SealSystemList.SealSystemListViewModel model)
        {
            SealSystem.Models.SealSystemList data = new SealSystem.Models.SealSystemList
            {
                Name = model.Name,
                Note = model.Note,
                Code = model.Code,
                Types = model.Types
            };
            await BLL.SealSystemListBLL.EditAsync(id, data);
            return Ok(new Models.ResponseData() { code = 200, Data="修改成功" });
        }
        /// <summary>
        /// 根据id删除相应的数据(伪删除)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("delete"),HttpGet]
        public async Task<IHttpActionResult> DeleteAsync(int id)
        {
            await BLL.SealSystemListBLL.DeleteAsync(id);
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        [Route("all"),HttpGet]
        public async Task<List<Models.SealSystemList.SealSystemListViewModel>> GetAllAsync()
        {
            var data= await BLL.SealSystemListBLL.GetAllAsync();
            List<Models.SealSystemList.SealSystemListViewModel> model = new List<Models.SealSystemList.SealSystemListViewModel>();
            foreach (SealSystem.Models.SealSystemList item in data)
            {
                model.Add(new Models.SealSystemList.SealSystemListViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Note = item.Note,
                    Code = item.Code,
                    Types = item.Types,
                    CreateTime = item.CreateTime
                });
            }
            return model;
        }
        /// <summary>
        /// 根据id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("getForId"),HttpGet]
        public async Task<Models.SealSystemList.SealSystemListViewModel> GetOneForIdAsync(int id)
        {
            var data=await BLL.SealSystemListBLL.GetOneForIdAsync(id);
            var model = new Models.SealSystemList.SealSystemListViewModel();
            model.Code = data.Code;
            model.Name = data.Name;
            model.Note = data.Note;
            model.Types = data.Types;
            model.Id = data.Id;
            model.CreateTime = data.CreateTime;
            return model;
        }
        /// <summary>
        /// 根据name获取下拉列表数据
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Route("getForName"),HttpGet]
        public async Task<List<string>> GetForNameAsync(string name)
        {
            return await BLL.SealSystemListBLL.GetForNameAsync(name);
        }
    }
}
