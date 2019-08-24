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
        
        public async Task AddAsync(string unitNumber, string name, string ethnicMinoritiesName, string englishName,
            int enterpriseType_Id, string voiceQueryPassword, string legelPerson, string idNumber, string unitAddress,
            string phone, string theZipCode, int sealUnitClass_Id, string enterpriseDocumentsType, string idNumbers)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                var data = new Models.SealUseUnitInfor()
                {
                    UnitNumber = unitNumber,
                    Name = name,
                    EthnicMinoritiesName = ethnicMinoritiesName,
                    EnglishName = englishName,
                    SealUnitCategory_Id = enterpriseType_Id,
                    VoiceQueryPassword = voiceQueryPassword,
                    LegelPerson = legelPerson,
                    IdNumber = idNumber,
                    UnitAddress = unitAddress,
                    Phone = phone,
                    TheZipCode = theZipCode,
                    SealUnitClass_Id = sealUnitClass_Id,
                    EnterpriseDocumentsType = enterpriseDocumentsType,
                    IdNumbers = idNumbers
                };
                await db.AddAsync(data);
            }
        }
        /// <summary>
        /// 增加印章使用单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static async Task AddAsync(Models.SealUseUnitInfor model)
        {
            using (var db = new DAL.SealUseUnitInforDAL())
            {
                Models.SealUseUnitInfor data = new Models.SealUseUnitInfor();
                data.Area_Id = model.Area_Id;
                data.EnglishName = model.EnglishName;
                data.EnterpriseDocumentsType = model.EnterpriseDocumentsType;
                data.EthnicMinoritiesName = model.EthnicMinoritiesName;
                data.IdNumber = model.IdNumber;
                data.IdNumbers = model.IdNumbers;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Phone = model.Phone;
                data.SealUnitCategory_Id = model.SealUnitCategory_Id;
                data.SealUnitClass_Id = model.SealUnitClass_Id;
                data.TheZipCode = model.TheZipCode;
                data.UnitAddress = model.UnitAddress;
                data.UnitNumber = model.UnitNumber;
                data.VoiceQueryPassword = model.VoiceQueryPassword;
                await db.AddAsync(data);
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
                data.Area_Id = model.Area_Id;
                data.EnglishName = model.EnglishName;
                data.EnterpriseDocumentsType = model.EnterpriseDocumentsType;
                data.EthnicMinoritiesName = model.EthnicMinoritiesName;
                data.IdNumber = model.IdNumber;
                data.IdNumbers = model.IdNumbers;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Phone = model.Phone;
                data.SealUnitCategory_Id = model.SealUnitCategory_Id;
                data.SealUnitClass_Id = model.SealUnitClass_Id;
                data.TheZipCode = model.TheZipCode;
                data.UnitAddress = model.UnitAddress;
                data.UnitNumber = model.UnitNumber;
                data.VoiceQueryPassword = model.VoiceQueryPassword;
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
                data.Area_Id = model.Area_Id;
                data.EnglishName = model.EnglishName;
                data.EnterpriseDocumentsType = model.EnterpriseDocumentsType;
                data.EthnicMinoritiesName = model.EthnicMinoritiesName;
                data.IdNumber = model.IdNumber;
                data.IdNumbers = model.IdNumbers;
                data.LegelPerson = model.LegelPerson;
                data.Name = model.Name;
                data.Phone = model.Phone;
                data.SealUnitCategory_Id = model.SealUnitCategory_Id;
                data.SealUnitClass_Id = model.SealUnitClass_Id;
                data.TheZipCode = model.TheZipCode;
                data.UnitAddress = model.UnitAddress;
                data.UnitNumber = model.UnitNumber;
                data.VoiceQueryPassword = model.VoiceQueryPassword;
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
