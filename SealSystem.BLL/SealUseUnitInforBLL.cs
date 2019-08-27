using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章使用单位信息
    /// </summary>
    public class SealUseUnitInforBLL
    {

        /// <summary>
        /// 增加印章使用单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task AddAsync(Models.SealUseUnitInfor model)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据单位编号修改印章使用单位信息
        /// </summary>
        /// <param name="unitNumber"></param>
        /// <returns></returns>
        public static async Task EditForUnitNumber(string unitNumber, Models.SealUseUnitInfor model)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.UnitNumber == unitNumber);
                data.EnglishName = model.EnglishName;
                data.EnterpriseDocumentsType = model.EnterpriseDocumentsType;
                data.EthnicMinoritiesName = model.EthnicMinoritiesName;
                data.IdNumber = model.IdNumber;
                data.IdNumbers = model.IdNumbers;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Note = model.Note;
                data.Phone = model.Phone;
                data.TheUnitType = model.TheUnitType;
                data.UnitAddress = model.UnitAddress;
                data.UnitClassification = model.UnitClassification;
                data.UnitNumber = model.UnitNumber;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 根据Id修改印章使用单位信息
        /// </summary>
        /// <param name="unitNumber"></param>
        /// <returns></returns>
        public static async Task EditForId(int id, Models.SealUseUnitInfor model)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                var data = await db.GetAll().FirstAsync(m => m.Id == id);
                data.EnglishName = model.EnglishName;
                data.EnterpriseDocumentsType = model.EnterpriseDocumentsType;
                data.EthnicMinoritiesName = model.EthnicMinoritiesName;
                data.IdNumber = model.IdNumber;
                data.IdNumbers = model.IdNumbers;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Note = model.Note;
                data.Phone = model.Phone;
                data.TheUnitType = model.TheUnitType;
                data.UnitAddress = model.UnitAddress;
                data.UnitClassification = model.UnitClassification;
                data.UnitNumber = model.UnitNumber;
                await db.EditAsync(data);
            }
        }
        /// <summary>
        /// 获取印章使用单位全部信息
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.SealUseUnitInfor>> GetAll()
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                return await db.GetAll().ToListAsync();
            }
        }
        /// <summary>
        /// 根据单位名称获取单位信息
        /// </summary>
        /// <param name="name">单位名称</param>
        /// <returns></returns>
        public static async Task<Models.SealUseUnitInfor> GetOneForName(string name)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                return await db.GetAll().FirstAsync(m => m.Name == name);
            }
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static async Task RemoveForId(int id)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                await db.RemoveAsync(id);
            }
        }
    }
}
