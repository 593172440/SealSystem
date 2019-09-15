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
                var data = new SealSystem.Models.TheOrder
                {
                    TheOrderCode = model.TheOrderCode,
                    ForTheRecordType = model.ForTheRecordType,
                    SealMakingUnitInfor_Name = model.SealMakingUnitInfor_Name,
                    TheRegistrationArea = model.TheRegistrationArea,
                    DeliveryTime = model.DeliveryTime,
                    IdCard=model.IdCard,
                    Phone=model.Phone,
                    TakeSealName=model.TakeSealName,
                    TakeTime=model.TakeTime,
                    UpTime=model.UpTime
                };
                await BLL.TheOrderBLL.Add(data);
                return Ok(new Models.ResponseData() { code = 200, Data = "增加成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 200, ErrorMessage = "增加失败" });
            }
        }
        /// <summary>
        /// 根据Id修改订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("edit"), HttpPost]
        public async Task<IHttpActionResult> Edit(int id, Models.TheOrder.TheOrderForAdd model)
        {
            var data = new SealSystem.Models.TheOrder();
            data.TheOrderCode = model.TheOrderCode;
            data.ForTheRecordType = model.ForTheRecordType;
            data.SealMakingUnitInfor_Name = model.SealMakingUnitInfor_Name;
            data.TheRegistrationArea = model.TheRegistrationArea;
            data.TakeSealName = model.TakeSealName;
            data.TakeTime = model.TakeTime;
            data.IdCard = model.IdCard;
            data.Phone = model.Phone;
            data.DeliveryTime = model.DeliveryTime;
            data.UpTime = model.UpTime;
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
            var data = await BLL.TheOrderBLL.GetAll();
            List<Models.TheOrder.TheOrderForALL> model = new List<Models.TheOrder.TheOrderForALL>();
            foreach (SealSystem.Models.TheOrder item in data)
            {
                model.Add(new Models.TheOrder.TheOrderForALL()
                {
                    Id = item.Id,
                    TheOrderCode = item.TheOrderCode,
                    CreateTime = item.CreateTime,
                    ForTheRecordType = item.ForTheRecordType,
                    SealMakingUnitInfor_Name = item.SealMakingUnitInfor_Name,
                    TheRegistrationArea = item.TheRegistrationArea,
                    DeliveryTime=item.DeliveryTime,
                    IdCard=item.IdCard,
                    Phone=item.Phone,
                    TakeSealName=item.TakeSealName,
                    TakeTime=item.TakeTime,
                    UpTime=item.UpTime
                });
            }
            return model;
        }
        /// <summary>
        /// 根据订单号获取订单信息
        /// </summary>
        /// <param name="theOrderCode"></param>
        /// <returns></returns>
        [Route("GetForTheOrderCode"), HttpGet]
        public async Task<Models.TheOrder.TheOrderForALL> GetForTheOrderCode(string theOrderCode)
        {
            var data = await BLL.TheOrderBLL.GetForTheOrderCode(theOrderCode);
            var model = new Models.TheOrder.TheOrderForALL()
            {
                ForTheRecordType = data.ForTheRecordType,
                Id = data.Id,
                CreateTime = data.CreateTime,
                SealMakingUnitInfor_Name = data.SealMakingUnitInfor_Name,
                TheOrderCode = data.TheOrderCode,
                TheRegistrationArea = data.TheRegistrationArea,
                TakeSealName=data.TakeSealName,
                DeliveryTime=data.DeliveryTime,
                IdCard=data.IdCard,
                Phone=data.Phone,
                TakeTime=data.TakeTime,
                UpTime=data.UpTime
            };
            return model;
        }
        /// <summary>
        /// 根据id获取订单号
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [Route("getForIdForTheOrderCode"), HttpGet]
        public async Task<string> GetForIdForTheOrderCode(int id)
        {
            return await BLL.TheOrderBLL.GetForIdForTheOrderCode(id);
        }
        /// <summary>
        /// 修改:根据订单号更新,取章人姓名/身份证号/手机号码(postman测试通过)
        /// </summary>
        /// <param name="theOrderCode">订单号</param>
        /// <param name="model">印章交付取章人信息</param>
        /// <returns></returns>
        [Route("setForTheOrderCode"), HttpPost]
        public async Task<IHttpActionResult> SetForTheOrderCode(string theOrderCode,Models.TheOrder.TheOrderForSealJiaoFu model)
        {
            await BLL.TheOrderBLL.SetForTheOrderCode(theOrderCode, model.TakeSealName, model.IdCard, model.Phone);
            return Ok(new Models.ResponseData() { code = 200, Data = "更新成功" });
        }
    }
}
