using System;
using System.Collections.Generic;
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
                    EnterpriseType_Id = enterpriseType_Id,
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
    }
}
