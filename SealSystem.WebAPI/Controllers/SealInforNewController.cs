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
        [Route("all"), HttpGet]
        public async Task<List<Models.SealINforNew.SealINforNewViewModelAll>> GetAll()
        {
            List<SealSystem.Models.SealInforNew> data = await BLL.SealInforNewBLL.GetAll();
            List<Models.SealINforNew.SealINforNewViewModelAll> dataViewModel = new List<Models.SealINforNew.SealINforNewViewModelAll>();
            foreach (var item in data)
            {
                dataViewModel.Add(new Models.SealINforNew.SealINforNewViewModelAll()
                {
                    EngravingLevel = item.EngravingLevel,
                    TheOrders_TheOrderCode = item.TheOrders_TheOrderCode,
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
                    SealApprovalUnitInfor_Id = item.SealApprovalUnitInfor_Id,
                    SealMakingUnitInfor_Id = item.SealMakingUnitInfor_Id,
                    Id = item.Id,
                    CreateTime = item.CreateTime
                });
            }
            return dataViewModel;
        }
        /// <summary>
        /// 获取所有数据,包括外键信息
        /// </summary>
        /// <returns></returns>
        [Route("allDetailed"), HttpGet]
        public async Task<List<SealSystem.Models.SealInforNew>> GetAllDetailed()
        {
            return await BLL.SealInforNewBLL.GetAllDetailed();
        }
        /// <summary>
        /// 根据印章编码获取印章信息
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <returns></returns>
        [Route("sealInForOne"), HttpGet]
        public async Task<SealSystem.Models.SealInforNew> GetSealInforOne(string sealInforNum)
        {
            return await BLL.SealInforNewBLL.GetSealInforOne(sealInforNum);
        }
        /// <summary>
        /// 根据印章编码获取印章信息带文件/图像地址(posman测试通过)
        /// </summary>
        /// <param name="sealInforNum">印章编码</param>
        /// <returns></returns>
        //[Route("sealInForOneFileUrl"), HttpGet]
        //public async Task<Models.SealINforNew.SealINforNewViewModelAllAndFileUrl> GetSealInforOneFileUrl(string sealInforNum)
        //{
        //    var data = await BLL.SealInforNewBLL.GetSealInforOne(sealInforNum);
        //    var model = new Models.SealINforNew.SealINforNewViewModelAllAndFileUrl()
        //    {
        //        CreateTime = data.CreateTime,
        //        EngravingLevel = data.EngravingLevel,
        //        EngravingType = data.EngravingType,
        //        ForeignLanguageContent = data.ForeignLanguageContent,
        //        Id = data.Id,
        //        MakeWay = data.MakeWay,
        //        Note = data.Note,
        //        RegistrationCategory = data.RegistrationCategory,
        //        SealApprovalUnitInfor_Id = data.SealApprovalUnitInfor_Id,
        //        SealCategory_Id_Code = data.SealCategory_Id_Code,
        //        SealContent = data.SealContent,
        //        SealInforNum = data.SealInforNum,
        //        SealMakingUnitInfor_Id = data.SealMakingUnitInfor_Id,
        //        SealMaterial = data.SealMaterial,
        //        SealShape = data.SealShape,
        //        SealState = data.SealState,
        //        SealUseUnitInfor_Id_UnitNumber = data.SealUseUnitInfor_Id_UnitNumber,
        //        TheOrders_TheOrderCode = data.TheOrders_TheOrderCode,
        //        TheProducer = data.TheProducer,
        //        FileUrl = (await BLL.FileAndImageBLL.GetFileAndImageOneForSealInforNew_Id(data.SealInforNum)).NamePath
        //    };
        //    return model;


        //}
        /// <summary>
        /// 根据订单号获取所有印章信息(posman测试通过)
        /// </summary>
        /// <param name="theOrders_TheOrderCode">订单号</param>
        /// <returns></returns>
        [Route("sealListFortheOrderCode"), HttpGet]
        public async Task<List<Models.SealINforNew.SealINforNewViewModelAll>> GetAllForTheOrders_TheOrderCode(string theOrders_TheOrderCode)
        {
            var data = await BLL.SealInforNewBLL.GetAllForTheOrders_TheOrderCode(theOrders_TheOrderCode);
            var model = new List<Models.SealINforNew.SealINforNewViewModelAll>();
            foreach (SealSystem.Models.SealInforNew item in data)
            {
                model.Add(new Models.SealINforNew.SealINforNewViewModelAll()
                {
                    CreateTime = item.CreateTime,
                    EngravingLevel = item.EngravingLevel,
                    EngravingType = item.EngravingType,
                    ForeignLanguageContent = item.ForeignLanguageContent,
                    Id = item.Id,
                    MakeWay = item.MakeWay,
                    Note = item.Note,
                    RegistrationCategory = item.RegistrationCategory,
                    SealApprovalUnitInfor_Id = item.SealApprovalUnitInfor_Id,
                    SealCategory_Id_Code = item.SealCategory_Id_Code,
                    SealContent = item.SealContent,
                    SealInforNum = item.SealInforNum,
                    SealMakingUnitInfor_Id = item.SealMakingUnitInfor_Id,
                    SealMaterial = item.SealMaterial,
                    SealShape = item.SealShape,
                    SealState = item.SealState,
                    SealUseUnitInfor_Id_UnitNumber = item.SealUseUnitInfor_Id_UnitNumber,
                    TheOrders_TheOrderCode = item.TheOrders_TheOrderCode,
                    TheProducer = item.TheProducer
                });
            }
            return model;
        }
        /// <summary>
        /// 根据订单号获取所有印章信息带文件/图像地址???这个有问题
        /// </summary>
        /// <param name="theOrders_TheOrderCode">订单号</param>
        /// <returns></returns>
        //[Route("sealListFortheOrderCodeFileUrl"), HttpGet]
        //public async Task<List<Models.SealINforNew.SealINforNewViewModelAllAndFileUrl>> GetAllForTheOrders_TheOrderCodeFileUrl(string theOrders_TheOrderCode)
        //{
        //    var data = await BLL.SealInforNewBLL.GetAllForTheOrders_TheOrderCode(theOrders_TheOrderCode);
        //    var model = new List<Models.SealINforNew.SealINforNewViewModelAllAndFileUrl>();
        //    foreach (SealSystem.Models.SealInforNew item in data)
        //    {
        //        string url = await BLL.FileAndImageBLL.GetFileUrl(item.SealInforNum);
        //        try
        //        {
        //            model.Add(new Models.SealINforNew.SealINforNewViewModelAllAndFileUrl()
        //            {
        //                CreateTime = item.CreateTime,
        //                EngravingLevel = item.EngravingLevel,
        //                EngravingType = item.EngravingType,
        //                ForeignLanguageContent = item.ForeignLanguageContent,
        //                Id = item.Id,
        //                MakeWay = item.MakeWay,
        //                Note = item.Note,
        //                RegistrationCategory = item.RegistrationCategory,
        //                SealApprovalUnitInfor_Id = item.SealApprovalUnitInfor_Id,
        //                SealCategory_Id_Code = item.SealCategory_Id_Code,
        //                SealContent = item.SealContent,
        //                SealInforNum = item.SealInforNum,
        //                SealMakingUnitInfor_Id = item.SealMakingUnitInfor_Id,
        //                SealMaterial = item.SealMaterial,
        //                SealShape = item.SealShape,
        //                SealState = item.SealState,
        //                SealUseUnitInfor_Id_UnitNumber = item.SealUseUnitInfor_Id_UnitNumber,
        //                TheOrders_TheOrderCode = item.TheOrders_TheOrderCode,
        //                TheProducer = item.TheProducer,
        //                FileUrl = url
        //            });
        //        }
        //        catch (Exception ex)
        //        {

        //            throw ex;
        //        }

        //    }
        //    return model;
        //}
        /// <summary>
        /// 增加一条印章信息数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task AddAsync(Models.SealINforNew.SealINforNewViewModelAll model)
        {
            if (ModelState.IsValid)
            {
                SealSystem.Models.SealInforNew data = new SealSystem.Models.SealInforNew
                {
                    TheOrders_TheOrderCode = model.TheOrders_TheOrderCode,
                    EngravingLevel = model.EngravingLevel,
                    EngravingType = model.EngravingType,
                    ForeignLanguageContent = model.ForeignLanguageContent,
                    MakeWay = model.MakeWay,
                    Note = model.Note,
                    RegistrationCategory = model.RegistrationCategory,
                    SealCategory_Id_Code = model.SealCategory_Id_Code,
                    SealContent = model.SealContent,
                    SealInforNum = model.SealInforNum,
                    SealMaterial = model.SealMaterial,
                    SealShape = model.SealShape,
                    SealState = model.SealState,
                    SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber,
                    TheProducer = model.TheProducer
                };
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
        public async Task EditAsync(string sealInforNum, Models.SealINforNew.SealINforNewViewModelAll model)
        {
            SealSystem.Models.SealInforNew data = new SealSystem.Models.SealInforNew
            {
                EngravingLevel = model.EngravingLevel,
                EngravingType = model.EngravingType,
                TheOrders_TheOrderCode = model.TheOrders_TheOrderCode,
                ForeignLanguageContent = model.ForeignLanguageContent,
                MakeWay = model.MakeWay,
                Note = model.Note,
                RegistrationCategory = model.RegistrationCategory,
                SealCategory_Id_Code = model.SealCategory_Id_Code,
                SealContent = model.SealContent,
                SealInforNum = model.SealInforNum,
                SealMaterial = model.SealMaterial,
                SealShape = model.SealShape,
                SealState = model.SealState,
                SealUseUnitInfor_Id_UnitNumber = model.SealUseUnitInfor_Id_UnitNumber,
                TheProducer = model.TheProducer
            };
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
        /// <summary>
        /// 修改:根据订单号修改所有的备案信息_id
        /// </summary>
        /// <param name="theOrders_TheOrderCode">订单号</param>
        /// <param name="id">备案信息id</param>
        /// <returns></returns>
        [Route("setForTheOrders_TheOrderCodeForSealApprovalUnitInfor_Id"), HttpGet]
        public async Task<IHttpActionResult> SetForTheOrders_TheOrderCodeForSealApprovalUnitInfor_Id(string theOrders_TheOrderCode,int id)
        {
            await BLL.SealInforNewBLL.SetForTheOrders_TheOrderCodeForSealApprovalUnitInfor_Id(theOrders_TheOrderCode,id);
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }

        //修改:根据订单号修改印章交付信息

        



        /// <summary>
        /// 根据id获取测试/正式印章图片(postman测试通过)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("testImagePathForId"), HttpGet]
        public async Task<string> GetTestImagePathForId(int id)
        {
            return "/images/SealImages/"+await BLL.SealInforNewBLL.GetTestImagePathForId(id);
        }
        /// <summary>
        /// 根据印章编码获取测试/正式印章图片(postman测试通过)
        /// </summary>
        /// <param name="sealInforNum"></param>
        /// <returns></returns>
        [Route("testImagePathForSealInforNum"), HttpGet]
        public async Task<string> GetTestImagePathForSealInforNum(string sealInforNum)
        {
            return "/images/SealImages/" + await BLL.SealInforNewBLL.GetTestImagePathForSealInforNum(sealInforNum);
        }
        /// <summary>
        /// 修改:根据印章编码修改印章信息(postman测试通过)
        /// </summary>
        /// <param name="sealInforNum"></param>
        /// <param name="models"></param>
        /// <returns></returns>
        [Route("setForTheOrders_TheOrderCode"), HttpPost]
        public async Task<IHttpActionResult> SetForTheOrders_TheOrderCode(string sealInforNum, Models.SealINforNew.SealINforNewViewModelJiaoFu models)
        {
            await BLL.SealInforNewBLL.SetForTheOrders_TheOrderCode(sealInforNum, new SealSystem.Models.SealInforNew() {
                SealMaterial = models.SealMaterial,
                MakeWay=models.MakeWay,
                Note=models.Note
            });
            return Ok(new Models.ResponseData() { code = 200, Data = "修改成功" });
        }
    }
}
