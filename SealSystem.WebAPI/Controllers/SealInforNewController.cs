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
        public async Task<List<Models.SealINforNew.SealINforNewViewModel>> GetAll()
        {
            List<SealSystem.Models.SealInforNew> data = await BLL.SealInforNewBLL.GetAll();
            List<Models.SealINforNew.SealINforNewViewModel> dataViewModel = new List<Models.SealINforNew.SealINforNewViewModel>();
            foreach (var item in data)
            {
                dataViewModel.Add(new Models.SealINforNew.SealINforNewViewModel()
                {
                    Approval = item.Approval,
                    ApprovalTime = item.ApprovalTime,
                    Attention = item.Attention,
                    AttentionIdCard = item.AttentionIdCard,
                    Contact = item.Contact,
                    EngravingLevel = item.EngravingLevel,
                    EngravingType = item.EngravingType,
                    ForeignLanguageContent = item.ForeignLanguageContent,
                    MakeWay = item.MakeWay,
                    Note = item.Note,
                    RegistrationCategory = item.RegistrationCategory,
                    SealApprovalUnitInfor_Id_ApprovalUnitCode = item.SealApprovalUnitInfor_Id_ApprovalUnitCode,
                    SealCategory_Id_Code = item.SealCategory_Id_Code,
                    SealContent = item.SealContent,
                    SealInforNum = item.SealInforNum,
                    SealMakingUnitInfor_Id_MakingUnitCode = item.SealMakingUnitInfor_Id_MakingUnitCode,
                    SealMaterial_Id_Code = item.SealMaterial_Id_Code,
                    SealShape = item.SealShape,
                    SealState = item.SealState,
                    SealUseUnitInfor_Id_UnitNumber = item.SealUseUnitInfor_Id_UnitNumber,
                    TheProducer = item.TheProducer
                });
            }
            return dataViewModel;
        }
        /// <summary>
        /// 获取所有的印章信息(包括外键信息)
        /// </summary>
        /// <returns></returns>
        [Route("GetAllDetailed"), HttpGet]
        public async Task<List<SealSystem.Models.SealInforNew>> GetAllDetailed()
        {
            return await BLL.SealInforNewBLL.GetAllDetailed();
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
        /// <summary>
        /// 根据id修改状态为-->[已录入]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("SetSealStateForLuRu"), HttpGet]
        public async Task SetSealStateForLuRu(int id)
        {
            await BLL.SealInforNewBLL.SetForSealState(id, "已录入");
        }
        /// <summary>
        /// 根据id修改状态为-->[待核验]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("SetSealStateForHeYan"), HttpGet]
        public async Task SetSealStateForHeYan(int id)
        {
            await BLL.SealInforNewBLL.SetForSealState(id, "待核验");
        }
        /// <summary>
        /// 根据id修改状态为-->[已备案]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("SetSealStateForBeiAn"), HttpGet]
        public async Task SetSealStateForBeiAn(int id)
        {
            await BLL.SealInforNewBLL.SetForSealState(id, "已备案");
        }
        /// <summary>
        /// 根据id修改状态为-->[已撤销](异步)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("SetSealStateForCheXiao"), HttpGet]
        public async Task<IHttpActionResult> SetSealStateForCheXiao(int id)
        {
            await BLL.SealInforNewBLL.SetForSealState(id, "已撤销");
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageSize">每页有多少条数据</param>
        /// <param name="pageIndex">有多少页</param>
        /// <returns></returns>
        [Route("GetAllPage"), HttpGet]
        public async Task<List<SealSystem.Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex)
        {
            return await BLL.SealInforNewBLL.GetAllPage(pageSize, pageIndex);
        }
        /// <summary>
        /// 分页加排序
        /// </summary>
        /// <param name="pageSize">每页有多少条数据</param>
        /// <param name="pageIndex">有多少页</param>
        /// <param name="asc">排序,true:正序,falas:降序</param>
        /// <returns></returns>
        [Route("GetAllPage"), HttpGet]
        public async Task<List<SealSystem.Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex, bool asc)
        {
            return await BLL.SealInforNewBLL.GetAllPage(pageSize, pageIndex, asc);
        }
    }
}
