﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SealSystem.BLL
{
    /// <summary>
    /// 印章信息
    /// </summary>
    public class SealInforNewBLL
    {
        /// <summary>
        /// 获取数据库中全部数据条数
        /// </summary>
        /// <returns></returns>
        public string GetAllCount()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                int str = db.GetAll().Count() + 10;//100
                string strs = str.ToString();
                int j = str.ToString().Length;
                int k = 7 - j;
                if (j < 7)
                {
                    for (int i = 0; i < k; i++)
                    {
                        strs = "0" + strs;
                    }
                }
                return strs;
            }
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAll()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 获取所有数据,包括外键信息
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllDetailed()
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var sealInforNews = db._db.SealInforNews.Include(s => s.SealCategory).Include(s => s.SealUseUnitInfor);
                return await sealInforNews.ToListAsync();
            }
        }
        /// <summary>
        /// 根据印章编码获取印章信息
        /// </summary>
        /// <param name="sealInforNum"></param>
        /// <returns></returns>
        public static async Task<Models.SealInforNew> GetSealInforOne(string sealInforNum)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
            }
        }
        /// <summary>
        /// 增加一条印章信息数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task AddAsync(Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据订单号获取所有订单信息
        /// </summary>
        /// <param name="theOrders_TheOrderCode"></param>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllForTheOrders_TheOrderCode(string theOrders_TheOrderCode)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAll().Where(m => m.TheOrders_TheOrderCode == theOrders_TheOrderCode).ToListAsync();
            }
        }
        /// <summary>
        /// 根据印章编码修改印章信息数据
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <returns></returns>
        public static async Task EditAsync(string sealInforNum, Models.SealInforNew model)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.SealInforNum == sealInforNum);
                data.EngravingLevel = model.EngravingLevel;
                data.EngravingType = model.EngravingType;
                data.ForeignLanguageContent = model.ForeignLanguageContent;
                data.MakeWay = model.MakeWay;
                data.Note = model.Note;
                data.RegistrationCategory = model.RegistrationCategory;
                data.SealCategory_Id_Code = model.SealCategory_Id_Code;
                data.SealContent = model.SealContent;
                data.SealInforNum = model.SealInforNum;
                data.SealMaterial = model.SealMaterial;
                data.SealShape = model.SealShape;
                data.SealState = model.SealState;
                data.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
                data.TheProducer = model.TheProducer;
                data.SealApprovalUnitInfor_Id = model.SealApprovalUnitInfor_Id;
                data.SealMakingUnitInfor_Id = model.SealMakingUnitInfor_Id;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 根据印章id伪删除印章信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task DeletedAsync(int id)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                await db.RemoveAsync(id);
            }
        }
        /// <summary>
        /// 根据id修改状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sealState"></param>
        /// <returns></returns>
        public static async Task SetForSealState(int id, string sealState)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                var data = await db.GetOneAsync(id);
                data.SealState = sealState;
                await db.EditAsync(data);
            }
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageSize">每页有多少条数据</param>
        /// <param name="pageIndex">有多少页</param>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAllByPage(pageSize, pageIndex).ToListAsync();
            }
        }
        /// <summary>
        /// 分页加排序
        /// </summary>
        /// <param name="pageSize">每页有多少条数据</param>
        /// <param name="pageIndex">有多少页</param>
        /// <param name="asc">排序</param>
        /// <returns></returns>
        public static async Task<List<Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex, bool asc)
        {
            using (var db = new DAL.SealInforNewDAL())
            {
                return await db.GetAllBypageOrder(pageSize, pageIndex, asc).ToListAsync();
            }
        }
    }
}
