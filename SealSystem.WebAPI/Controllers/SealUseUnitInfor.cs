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
        [Route("add"), HttpPost]
        public async Task<IHttpActionResult> AddAsync(Models.SealUseUnitInfor.SealUseUnitInforForAdd model)
        {
            if (ModelState.IsValid)
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
                return Ok(new Models.ResponseData() { code = 200, Data = "增加成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 400, ErrorMessage="增加失败" });
            }
        }

        /// <summary>
        /// 根据单位编号修改印章使用单位信息
        /// </summary>
        /// <param name="unitNumber"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("editForUnitNumber"), HttpPost]
        public async Task<IHttpActionResult> EditForUnitNumber(string unitNumber, Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            if (ModelState.IsValid)
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
                return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 200, ErrorMessage="修改失败" });
            }

        }
        /// <summary>
        /// 根据Id修改印章使用单位信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("editForId"), HttpPost]
        public async Task<IHttpActionResult> EditForId(int id, Models.SealUseUnitInfor.SealUseUnitInforViewModel model)
        {
            if (ModelState.IsValid)
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
                return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
            }
            else
            {
                return Ok(new Models.ResponseData() { code = 200, ErrorMessage = "修改失败" });
            }
        }
        /// <summary>
        /// 获取印章使用单位全部信息
        /// </summary>
        /// <returns></returns>
        [Route("all"), HttpGet]
        public async Task<List<Models.SealUseUnitInfor.SealUseUnitInforViewModel>> GetAll()
        {
            var db = await BLL.SealUseUnitInforBLL.GetAll();
            var data = new List<Models.SealUseUnitInfor.SealUseUnitInforViewModel>();
            foreach (SealSystem.Models.SealUseUnitInfor model in db)
            {
                data.Add(new Models.SealUseUnitInfor.SealUseUnitInforViewModel()
                {
                    Id = model.Id,
                    CreateTime = model.CreateTime,
                    EnglishName = model.EnglishName,
                    EnterpriseDocumentsType = model.EnterpriseDocumentsType,
                    EthnicMinoritiesName = model.EthnicMinoritiesName,
                    IdNumber = model.IdNumber,
                    IdNumbers = model.IdNumbers,
                    LegelPerson = model.LegelPerson,
                    Name = model.Name,
                    Note = model.Note,
                    Phone = model.Phone,
                    TheUnitType = model.TheUnitType,
                    UnitAddress = model.UnitAddress,
                    UnitClassification = model.UnitClassification,
                    UnitNumber = model.UnitNumber
                });
            }
            return data;
        }
        /// <summary>
        /// 根据单位名称获取单位信息
        /// </summary>
        /// <param name="name">单位名称</param>
        /// <returns></returns>
        [Route("getForName"), HttpGet]
        public async Task<Models.SealUseUnitInfor.SealUseUnitInforViewModel> GetOneForName(string name)
        {
            var model = await BLL.SealUseUnitInforBLL.GetOneForName(name);
            var data = new Models.SealUseUnitInfor.SealUseUnitInforViewModel();
            data.Id = model.Id;
            data.CreateTime = model.CreateTime;
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
            return data;
        }
        /// <summary>
        /// 根据id删除相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("RemoveForId"), HttpGet]
        public async Task<IHttpActionResult> RemoveForId(int id)
        {
            await BLL.SealUseUnitInforBLL.RemoveForId(id);
            return Ok(new Models.ResponseData() { code = 200, Data = "删除成功" });
        }
    }
}