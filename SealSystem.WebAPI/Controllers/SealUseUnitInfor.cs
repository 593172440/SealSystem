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
        [Route("add"),HttpPost]
        public async Task AddAsync(Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            SealSystem.Models.SealUseUnitInfor data = new SealSystem.Models.SealUseUnitInfor();
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
            await BLL.SealUseUnitInforBLL.AddAsync(data);
        }

        /// <summary>
        /// 根据单位编号修改印章使用单位信息
        /// </summary>
        /// <param name="unitNumber"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("editForNnitNumber"),HttpPost]
        public async Task EditForUnitNumber(string unitNumber, Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            SealSystem.Models.SealUseUnitInfor data = new SealSystem.Models.SealUseUnitInfor();
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
            await BLL.SealUseUnitInforBLL.EditForUnitNumber(unitNumber, data);

        }
        /// <summary>
        /// 根据Id修改印章使用单位信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("editForId"),HttpPost]
        public async Task EditForId(int id, Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            SealSystem.Models.SealUseUnitInfor data = new SealSystem.Models.SealUseUnitInfor();
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
            await BLL.SealUseUnitInforBLL.EditForId(id, data);
        }
        /// <summary>
        /// 获取印章使用单位全部信息
        /// </summary>
        /// <returns></returns>
        [Route("all"),HttpGet]
        public async Task<List<SealSystem.Models.SealUseUnitInfor>> GetAll()
        {
            return await BLL.SealUseUnitInforBLL.GetAll();
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("deleteForId"),HttpGet]
        public async Task RemoveForId(int id)
        {
            await BLL.SealUseUnitInforBLL.RemoveForId(id);
        }
    }
}