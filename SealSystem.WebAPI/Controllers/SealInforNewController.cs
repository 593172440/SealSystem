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
        [Route("all")]
        public async Task<List<Models.SealINforNew.SealINforNewViewModel>> GetAll()
        {
            List<SealSystem.Models.SealInforNew> data = await BLL.SealInforNewBLL.GetAll();
            List<Models.SealINforNew.SealINforNewViewModel> dataViewModel = new List<Models.SealINforNew.SealINforNewViewModel>();
            foreach (var item in data)
            {
                dataViewModel.Add(new Models.SealINforNew.SealINforNewViewModel()
                {
                EngravingLevel = item.EngravingLevel,
                EngravingType = item.EngravingType,
                ForeignLanguageContent = item.ForeignLanguageContent,
                MakeWay = item.MakeWay,
                Note = item.Note,
                RegistrationCategory = item.RegistrationCategory,
                SealCategory_Id_Code = item.SealCategory_Id_Code,
                SealContent = item.SealContent,
                SealInforNum = item.SealInforNum,
                SealMaterial = item.SealMaterial,
                SealShape = item.SealShape,
                SealState = item.SealState,
                SealUseUnitInfor_Id_UnitNumber = item.SealUseUnitInfor_Id_UnitNumber,
                TheProducer = item.TheProducer,
            });
        }
            return dataViewModel;
        }
  
    /// <summary>
    /// 根据印章编码获取印章信息
    /// </summary>
    /// <param name="sealInforNum">印章编码</param>
    /// <returns></returns>
    [Route("sealInForOne"),HttpGet]
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
    [Route("add")]
    public async Task AddAsync(Models.SealINforNew.SealINforNewViewModel model)
    {
        if (ModelState.IsValid)
        {
            SealSystem.Models.SealInforNew data = new SealSystem.Models.SealInforNew();
            data.EngravingLevel = model.EngravingLevel;
            data.EngravingType = model.EngravingType;
            data.ForeignLanguageContent = model.ForeignLanguageContent;
            data.MakeWay = model.MakeWay;
            data.Note = model.Note;
            data.RegistrationCategory = model.RegistrationCategory;
            data.SealCategory_Id_Code = model.SealCategory_Id_Code;
            data.SealContent = model.SealContent;
            data.SealInforNum = model.SealInforNum;
            data.SealMaterial = model.SealMaterial;
            data.SealShape = model.SealShape;
            data.SealState = model.SealState;
            data.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
            data.TheProducer = model.TheProducer;
            await BLL.SealInforNewBLL.AddAsync(data);
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
    [Route("editForSealInforNum")]
    public async Task EditAsync(string sealInforNum, Models.SealINforNew.SealINforNewViewModel model)
    {
        SealSystem.Models.SealInforNew data = new SealSystem.Models.SealInforNew();
        data.EngravingLevel = model.EngravingLevel;
        data.EngravingType = model.EngravingType;
        data.ForeignLanguageContent = model.ForeignLanguageContent;
        data.MakeWay = model.MakeWay;
        data.Note = model.Note;
        data.RegistrationCategory = model.RegistrationCategory;
        data.SealCategory_Id_Code = model.SealCategory_Id_Code;
        data.SealContent = model.SealContent;
        data.SealInforNum = model.SealInforNum;
        data.SealMaterial = model.SealMaterial;
        data.SealShape = model.SealShape;
        data.SealState = model.SealState;
        data.SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber;
        data.TheProducer = model.TheProducer;
        await BLL.SealInforNewBLL.EditAsync(sealInforNum, data);
    }
    /// <summary>
    /// 根据印章id伪删除印章信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Route("delete")]
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
    public async Task<IHttpActionResult> SetSealStateForLuRu(int id)
    {
        await BLL.SealInforNewBLL.SetForSealState(id, "已录入");
        return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
    }
    /// <summary>
    /// 根据id修改状态为-->[待核验]
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Route("setForHeYan"), HttpGet]
    public async Task<IHttpActionResult> SetSealStateForHeYan(int id)
    {
        await BLL.SealInforNewBLL.SetForSealState(id, "待核验");
        return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
    }
    /// <summary>
    /// 根据id修改状态为-->[已备案]
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Route("setForBeiAn"), HttpGet]
    public async Task<IHttpActionResult> SetSealStateForBeiAn(int id)
    {
        await BLL.SealInforNewBLL.SetForSealState(id, "已备案");
        return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
    }
    /// <summary>
    /// 根据id修改状态为-->[已撤销](异步)
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Route("setForCheXiao"), HttpGet]
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
    [Route("allPage"), HttpGet]
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
    [Route("allPageForAsc"), HttpGet]
    public async Task<List<SealSystem.Models.SealInforNew>> GetAllPage(int pageSize, int pageIndex, bool asc)
    {
        return await BLL.SealInforNewBLL.GetAllPage(pageSize, pageIndex, asc);
    }
}
}
