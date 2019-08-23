using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.BLL
{
    /// <summary>
    /// 印章制作单位信息
    /// </summary>
    public class SealMakingUnitInforBLL
    {
        /// <summary>
        /// 增加印章制作单位
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task AddAsync(Models.SealMakingUnitInfor model)
        {
            using (var db = new DAL.SealMakingUnitInforDAL())
            {
                await db.AddAsync(model);
            }
        }
        /// <summary>
        /// 根据印章制作单位Id修改相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task EditAsync(int id, Models.SealMakingUnitInfor model)
        {
            using (var db = new DAL.SealMakingUnitInforDAL())
            {
                var sealInfo = await db.GetAll().FirstAsync(m => m.Id == id);
                sealInfo.BusinessLicense = model.BusinessLicense;
                sealInfo.BusinessState = model.BusinessState;
                sealInfo.Contact = model.Contact;
                sealInfo.ContanctPhone = model.ContanctPhone;
                sealInfo.EnglishName = model.EnglishName;
                sealInfo.EthnicMinoritiesName = model.EthnicMinoritiesName;
                sealInfo.IdNumber = model.IdNumber;
                sealInfo.LegelPerson = model.LegelPerson;
                sealInfo.MakingUnitCode = model.MakingUnitCode;
                sealInfo.Name = model.Name;
                sealInfo.Phone = model.Phone;
                sealInfo.Remarks = model.Remarks;
                sealInfo.TheZipCode = model.TheZipCode;
                sealInfo.UnitAddress = model.UnitAddress;
                await db.EditAsync(sealInfo);
            }
        }
    }
}
