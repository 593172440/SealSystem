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
    /// 印章备案(审批)单位信息
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/SealApprovalUnitInfor")]
    public class SealApprovalUnitInforController : ApiController
    {
        /// <summary>
        /// 增加印章备案(审批)单位信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("AddAsync"), HttpPost]
        public async Task AddAsync(SealSystem.Models.SealApprovalUnitInfor model)
        {
            await BLL.SealApprovalUnitInforBLL.AddAsync(model);
        }
        /// <summary>
        /// 根据备案单位编码修改相应的信息
        /// </summary>
        /// <param name="approvalUnitCode"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("EditForApprovalUnitCodeAsync"),HttpPost]
        public async Task EditForApprovalUnitCodeAsync(string approvalUnitCode, Models.SealApprovalUnitInfor.SealApprovalUnitInforViewModel model)
        {
            var data = new SealSystem.Models.SealApprovalUnitInfor();
            data.Approval = model.Approval;
            data.ApprovalUnitCode = model.ApprovalUnitCode;
            data.Attention = model.Attention;
            data.AttentionIdCard = model.AttentionIdCard;
            data.Contact = model.Contact;
            data.Name = model.Name;
            data.Note = model.Note;
            data.SealInforNew_Id = model.SealInforNew_Id;
            await BLL.SealApprovalUnitInforBLL.EditForApprovalUnitCodeAsync(approvalUnitCode, data);
        }
        /// <summary>
        /// 根据Id修改相应的信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("EditForIdAsync"),HttpPost]
        public async Task EditForIdAsync(int id, Models.SealApprovalUnitInfor.SealApprovalUnitInforViewModel model)
        {
            var data = new SealSystem.Models.SealApprovalUnitInfor();
            data.Approval = model.Approval;
            data.ApprovalUnitCode = model.ApprovalUnitCode;
            data.Attention = model.Attention;
            data.AttentionIdCard = model.AttentionIdCard;
            data.Contact = model.Contact;
            data.Name = model.Name;
            data.Note = model.Note;
            data.SealInforNew_Id = model.SealInforNew_Id;
            await BLL.SealApprovalUnitInforBLL.EditForIdAsync(id, data);
        }
        /// <summary>
        /// 获取印章备案(审批)单位信息所有数据
        /// </summary>
        /// <returns></returns>
        [Route("GetAll"),HttpGet]
        public async Task<List<SealSystem.Models.SealApprovalUnitInfor>> GetAll()
        {
            return await BLL.SealApprovalUnitInforBLL.GetAll();
        }
        /// <summary>
        /// 根据Id获取相应的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetForId"), HttpGet]
        public async Task<SealSystem.Models.SealApprovalUnitInfor> GetForId(int id)
        {
            return await BLL.SealApprovalUnitInforBLL.GetForId(id);
        }
        /// <summary>
        /// 根据备案单位编码获取相应的数据
        /// </summary>
        /// <param name="approvalUnitCode"></param>
        /// <returns></returns>
        [Route("GetForApprovalUnitCode"), HttpGet]
        public async Task<SealSystem.Models.SealApprovalUnitInfor> GetForApprovalUnitCode(string approvalUnitCode)
        {
            return await BLL.SealApprovalUnitInforBLL.GetForApprovalUnitCode(approvalUnitCode);
        }
    }
}
