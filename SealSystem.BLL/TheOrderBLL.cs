﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 订单表(第二步:添加印章信息上面部分)
    /// </summary>
    public class TheOrderBLL
    {
        /// <summary>
        /// 增加一条订单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task Add(Models.TheOrder model)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据Id修改订单信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task Edit(int id, Models.TheOrder model)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.Id == id);
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
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 获取订单的全部信息
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.TheOrder>> GetAll()
        {
            using (var db = new DAL.TheOrderDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据订单号获取订单信息
        /// </summary>
        /// <param name="TheOrderCode"></param>
        /// <returns></returns>
        public static async Task<Models.TheOrder> GetForTheOrderCode(string theOrderCode)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                return await db.GetAll().FirstAsync(m => m.TheOrderCode == theOrderCode);
            }
        }
        /// <summary>
        /// 根据id获取订单号
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<string> GetForIdForTheOrderCode(int id)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                return (await db.GetOneAsync(id)).TheOrderCode;
            }
        }
        /// <summary>
        /// 根据订单号更新,取章人姓名/身份证号/手机号码
        /// </summary>
        /// <param name="theOrderCode">订单号</param>
        /// <param name="takeSealName">取章人姓名</param>
        /// <param name="idCard">身份证号</param>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public static async Task SetForTheOrderCode(string theOrderCode,string takeSealName,string idCard,string phone)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                var data= await db.GetAll().FirstAsync(m => m.TheOrderCode == theOrderCode);
                data.TakeSealName = takeSealName;
                data.IdCard = idCard;
                data.Phone = phone;
                data.DeliveryTime = DateTime.Now;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 修改:根据订单号更新状态
        /// </summary>
        /// <param name="theOrderCode">订单号</param>
        /// <param name="sealState">订单状态</param>
        /// <returns></returns>
        public static async Task SetSealStateForTheOrderCode(string theOrderCode,string sealState)
        {
            using (var db = new DAL.TheOrderDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.TheOrderCode == theOrderCode);
                data.SealState = sealState;
                await db.EditAsync(data);
            }
        }
    }
}
