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
    /// 订单表(第二步:添加印章信息上面部分)(Postman测试通过)
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/TheOrder")]
    public class TheOrderController : ApiController
    {
        /// <summary>
        /// 增加一条订单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("add"), HttpPost]
        public async Task<IHttpActionResult> Add(Models.TheOrder.TheOrderForAdd model)
        {
            if (ModelState.IsValid)
            {
                var data = new SealSystem.Models.TheOrder();
                data.ForTheRecordType = model.ForTheRecordType;
                data.SealInforNum = model.SealInforNum;
                data.SealMakingUnitInfor_Name = model.SealMakingUnitInfor_Name;
                data.TheRegistrationArea = model.TheRegistrationArea;
                await BLL.TheOrderBLL.Add(data);
                return Ok(new Models.ResponseData() { code = 200, Data = "增加成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 200, ErrorMessage="增加失败" });
            }
        }
        /// <summary>
        /// 根据Id修改订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("edit"),HttpPost]
        public async Task<IHttpActionResult> Edit(int id, Models.TheOrder.TheOrderForAdd model)
        {
            var data = new SealSystem.Models.TheOrder();
            data.ForTheRecordType = model.ForTheRecordType;
            data.SealInforNum = model.SealInforNum;
            data.SealMakingUnitInfor_Name = model.SealMakingUnitInfor_Name;
            data.TheRegistrationArea = model.TheRegistrationArea;
            await BLL.TheOrderBLL.Edit(id, data);
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });

        }
        /// <summary>
        /// 获取订单的全部信息
        /// </summary>
        /// <returns></returns>
        [Route("all"), HttpGet]
        public async Task<List<Models.TheOrder.TheOrderForALL>> GetAll()
        {
            var data=await BLL.TheOrderBLL.GetAll();
            List<Models.TheOrder.TheOrderForALL> model = new List<Models.TheOrder.TheOrderForALL>();
            foreach (SealSystem.Models.TheOrder item in data)
            {
                model.Add(new Models.TheOrder.TheOrderForALL()
                {
                    Id = item.Id,
                    CreateTime = item.CreateTime,
                    ForTheRecordType = item.ForTheRecordType,
                    SealInforNum = item.SealInforNum,
                    SealMakingUnitInfor_Name = item.SealMakingUnitInfor_Name,
                    TheRegistrationArea = item.TheRegistrationArea
                });
            }
            return model;
        }
    }
}
