using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SealSystem.WebAPI.Controllers
{
    /// <summary>
    /// 印章使用单位信息
    /// </summary>
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/SealUseUnitInfor")]
    public class SealUseUnitInforController : ApiController
    {
       
        /// <summary>
        /// 增加印章使用单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("AddAsync")]
        public async Task AddAsync(Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            SealSystem.Models.SealUseUnitInfor data = new SealSystem.Models.SealUseUnitInfor();
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
            await BLL.SealUseUnitInforBLL.AddAsync(data);
        }

        /// <summary>
        /// 根据单位编号修改印章使用单位信息
        /// </summary>
        /// <param name="unitNumber"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task EditForUnitNumber(string unitNumber, Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            SealSystem.Models.SealUseUnitInfor data = new SealSystem.Models.SealUseUnitInfor();
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
            await BLL.SealUseUnitInforBLL.EditForUnitNumber(unitNumber, data);

        }
        /// <summary>
        /// 根据Id修改印章使用单位信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task EditForId(int id, Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            SealSystem.Models.SealUseUnitInfor data = new SealSystem.Models.SealUseUnitInfor();
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
            await BLL.SealUseUnitInforBLL.EditForId(id, data);
        }
        /// <summary>
        /// 获取印章使用单位全部信息
        /// </summary>
        /// <returns></returns>
        [Route("GetAll")]
        public async Task<List<SealSystem.Models.SealUseUnitInfor>> GetAll()
        {
            return await BLL.SealUseUnitInforBLL.GetAll();
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("RemoveForId")]
        public async Task RemoveForId(int id)
        {
            await BLL.SealUseUnitInforBLL.RemoveForId(id);
        }
    }
}