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
    /// 印章制作单位信息
    /// </summary>
    [RoutePrefix("api/SealMakingUnitInfor")]
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class SealMakingUnitInforController : ApiController
    {
        /// <summary>
        /// 增加印章制作单位
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("AddAsync"),HttpPost]
        public async Task AddAsync(Models.SealMakingUnitInfor.SealMakingUnitInforViewModel model)
        {
            SealSystem.Models.SealMakingUnitInfor seal = new SealSystem.Models.SealMakingUnitInfor();
            seal.BusinessLicense = model.BusinessLicense;
            seal.BusinessState = model.BusinessState;
            seal.Contact = model.Contact;
            seal.ContanctPhone = model.ContanctPhone;
            seal.EnglishName = model.EnglishName;
            seal.EthnicMinoritiesName = model.EthnicMinoritiesName;
            seal.IdNumber = model.IdNumber;
            seal.LegelPerson = model.LegelPerson;
            seal.MakingUnitCode = model.MakingUnitCode;
            seal.Name = model.Name;
            seal.Phone = model.Phone;
            seal.Remarks = model.Remarks;
            seal.TheZipCode = model.TheZipCode;
            seal.UnitAddress = model.UnitAddress;
            await BLL.SealMakingUnitInforBLL.AddAsync(seal);

        }
        /// <summary>
        /// 根据印章制作单位Id修改相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("EditAsync")]
        public async Task EditAsync(int id, Models.SealMakingUnitInfor.SealMakingUnitInforViewModel model)
        {
            SealSystem.Models.SealMakingUnitInfor sealInfo = new SealSystem.Models.SealMakingUnitInfor();
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
            await BLL.SealMakingUnitInforBLL.EditAsync(id, sealInfo);
        }
    }
}
