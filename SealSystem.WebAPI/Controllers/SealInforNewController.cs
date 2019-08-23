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
    /// 印章信息
    /// </summary>
    [RoutePrefix("api/SealInforNew")]
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class SealInforNewController : ApiController
    {
        /// <summary>
        /// 获取所有的印章信息
        /// </summary>
        /// <returns></returns>
        [Route("GetAll")]
        public async Task<List<SealSystem.Models.SealInforNew>> GetAll()
        {
            return await BLL.SealInforNewBLL.GetAll();
        }
        /// <summary>
        /// 根据印章编码获取印章信息
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <returns></returns>
        [Route("GetSealInforOne")]
        public async Task<SealSystem.Models.SealInforNew> GetSealInforOne(string sealInforNum)
        {
            return await BLL.SealInforNewBLL.GetSealInforOne(sealInforNum);
        }
        /// <summary>
        /// 增加一条印章信息数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddAsync")]
        public async Task AddAsync(Models.SealINforNew.SealINforNewViewModel model)
        {
            if (ModelState.IsValid)
            {
                BLL.SealInforNewBLL db = new BLL.SealInforNewBLL();
                SealSystem.Models.SealInforNew se = new SealSystem.Models.SealInforNew();
                se.Approval = model.Approval;
                se.ApprovalTime = model.ApprovalTime;
                se.Attention = model.Attention;
                se.AttentionIdCard = model.AttentionIdCard;
                se.Contact = model.Contact;
                se.EngravingLevel = model.EngravingLevel;
                se.EngravingType = model.EngravingType;
                se.ForeignLanguageContent = model.ForeignLanguageContent;
                se.MakeWay = model.MakeWay;
                se.Note = model.Note;
                se.RegistrationCategory = model.RegistrationCategory;
                se.SealApprovalUnitInfor_Id_ApprovalUnitCode = model.SealApprovalUnitInfor_Id_ApprovalUnitCode;
                se.SealCategory_Id_Code = model.SealCategory_Id_Code;
                se.SealContent = model.SealContent;
                se.SealInforNum = model.SealInforNum;
                se.SealMakingUnitInfor_Id_MakingUnitCode = model.SealMakingUnitInfor_Id_MakingUnitCode;
                se.SealMaterial_Id_Code = model.SealMaterial_Id_Code;
                se.SealShape = model.SealShape;
                se.SealState = model.SealState;
                se.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
                se.TheProducer = model.TheProducer;
                await db.AddAsync(se);
            }
            else
            {
                new Exception("信息有误,请检查_Id的数据为必须填写");
            }
        }
        /// <summary>
        /// 根据印章编码修改印章信息
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("EditAsync")]
        public async Task EditAsync(string sealInforNum, Models.SealINforNew.SealINforNewViewModel model)
        {
            SealSystem.Models.SealInforNew se = new SealSystem.Models.SealInforNew();
            se.Approval = model.Approval;
            se.ApprovalTime = model.ApprovalTime;
            se.Attention = model.Attention;
            se.AttentionIdCard = model.AttentionIdCard;
            se.Contact = model.Contact;
            se.EngravingLevel = model.EngravingLevel;
            se.EngravingType = model.EngravingType;
            se.ForeignLanguageContent = model.ForeignLanguageContent;
            se.MakeWay = model.MakeWay;
            se.Note = model.Note;
            se.RegistrationCategory = model.RegistrationCategory;
            se.SealApprovalUnitInfor_Id_ApprovalUnitCode = model.SealApprovalUnitInfor_Id_ApprovalUnitCode;
            se.SealCategory_Id_Code = model.SealCategory_Id_Code;
            se.SealContent = model.SealContent;
            se.SealInforNum = model.SealInforNum;
            se.SealMakingUnitInfor_Id_MakingUnitCode = model.SealMakingUnitInfor_Id_MakingUnitCode;
            se.SealMaterial_Id_Code = model.SealMaterial_Id_Code;
            se.SealShape = model.SealShape;
            se.SealState = model.SealState;
            se.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
            se.TheProducer = model.TheProducer;
            await BLL.SealInforNewBLL.EditAsync(sealInforNum, se);
        }
        /// <summary>
        /// 根据印章id伪删除印章信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DeletedAsync")]
        [HttpGet]
        public async Task DeletedAsync(int id)
        {
            await BLL.SealInforNewBLL.DeletedAsync(id);
        }
    }
}
