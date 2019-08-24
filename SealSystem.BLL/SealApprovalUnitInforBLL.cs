using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    public class SealApprovalUnitInforBLL
    {
        /// <summary>
        /// 增加印章备案(审批)单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task AddAsync(Models.SealApprovalUnitInfor model)
        {
            using (var db = new DAL.SealApprovalUnitInforDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据备案单位编码修改相应的信息
        /// </summary>
        /// <param name="ApprovalUnitCode"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task EditForApprovalUnitCodeAsync(string approvalUnitCode, Models.SealApprovalUnitInfor model)
        {
            using (var db = new DAL.SealApprovalUnitInforDAL())
            {
                var data = await db.GetAll().FirstAsync(m=>m.ApprovalUnitCode==approvalUnitCode);
                data.ApprovalUnitCode = model.ApprovalUnitCode;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Phone = model.Phone;
                data.TheZipCode = model.TheZipCode;
                data.UnitAddress = model.UnitAddress;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 根据Id修改相应的信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task EditForIdAsync(int id, Models.SealApprovalUnitInfor model)
        {
            using (var db = new DAL.SealApprovalUnitInforDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.Id == id);
                data.ApprovalUnitCode = model.ApprovalUnitCode;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Phone = model.Phone;
                data.TheZipCode = model.TheZipCode;
                data.UnitAddress = model.UnitAddress;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 获取印章备案(审批)单位信息所有数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealApprovalUnitInfor>> GetAll()
        {
            using (var db = new DAL.SealApprovalUnitInforDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据Id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task<Models.SealApprovalUnitInfor> GetForId(int id)
        {
            using (var db = new DAL.SealApprovalUnitInforDAL())
            {
                return await db.GetOneAsync(id);
            }
        }
        /// <summary>
        /// 根据备案单位编码获取相应的数据
        /// </summary>
        /// <param name="approvalUnitCode"></param>
        /// <returns></returns>
        public static async Task<Models.SealApprovalUnitInfor> GetForApprovalUnitCode(string approvalUnitCode)
        {
            using (var db = new DAL.SealApprovalUnitInforDAL())
            {
                return await db.GetAll().FirstAsync(m => m.ApprovalUnitCode == approvalUnitCode);
            }
        }
    }
}
