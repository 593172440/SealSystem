using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章基本信息表
    /// </summary>
    public class SealInfor:BaseEntity
    {
        /// <summary>
        /// 印章编号(标准：GA 241.1)
        /// </summary>
        [Required]
        public int SealInforNum { get; set; }
        /// <summary>
        /// 印章名称
        /// </summary>
        public int SealName { get; set; }
        /// <summary>
        /// 印章状态代码(标准：GA 241.2)
        /// </summary>
        [ForeignKey(nameof(SealState))]
        public int SealState_Id_Code { get; set; }
        public SealState SealState { get; set; }
        /// <summary>
        /// 使用单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealUseUnitInfor))]
        public int SealUseUnitInfor_Id_UnitNumber { get; set; }
        public SealUseUnitInfor SealUseUnitInfor { get; set; }
        /// <summary>
        /// 审批单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealApprovalUnitInfor))]
        public int SealApprovalUnitInfor_Id_ApprovalUnitCode { get; set; }
        public SealApprovalUnitInfor SealApprovalUnitInfor { get; set; }
        /// <summary>
        /// 制作单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealMakingUnitInfor))]
        public int SealMakingUnitInfor_Id_MakingUnitCode { get; set; }
        public SealMakingUnitInfor SealMakingUnitInfor { get; set; }
        /// <summary>
        /// 印章类型代码(标准：GA 241.2)
        /// </summary>
        [ForeignKey(nameof(SealCategory))]
        public int SealCategory_Id_Code { get; set; }
        public SealCategory SealCategory { get; set; }
        /// <summary>
        /// 章面材料代码(标准：GA 241.2)
        /// </summary>
        [ForeignKey(nameof(SealMaterial))]
        public int SealMaterial_Id_Code { get; set; }
        public SealMaterial SealMaterial { get; set; }
        /// <summary>
        /// 印油说明
        /// </summary>
        public string ManyInstructions { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string Attention { get; set; }
        /// <summary>
        /// 经办人身份证
        /// </summary>
        public string AttentionIdCard { get; set; }
        /// <summary>
        /// 审批人
        /// </summary>
        public string Approval{ get; set; }
        /// <summary>
        /// 审批日期
        /// </summary>
        public DateTime ApprovalTime { get; set; }
        /// <summary>
        /// 承接日期
        /// </summary>
        public DateTime UndertakeTime { get; set; }
        /// <summary>
        /// 制作日期
        /// </summary>
        public DateTime MakingTime { get; set; }
        /// <summary>
        /// 交付日期
        /// </summary>
        public DateTime DeliveryTime { get; set; }
        /// <summary>
        /// 报废日期
        /// </summary>
        public DateTime ScrapTime { get; set; }
        /// <summary>
        /// 缴销日期
        /// </summary>
        public DateTime HandTime { get; set; }
        /// <summary>
        /// 挂失日期
        /// </summary>
        public DateTime LossTime { get; set; }
        /// <summary>
        /// 最后年检日期
        /// </summary>
        public DateTime LastAnnualTime { get; set; }
        /// <summary>
        /// 印章图像信息(外键)
        /// </summary>
        [ForeignKey(nameof(SealImageData))]
        public int SealImageData_Id { get; set; }
        public SealImageData SealImageData { get; set; }

        //------------------------------------------------
        /// <summary>
        /// 印章规格(自定义下拉列表)
        /// </summary>
        public int SealSpecification { get; set; }
        /// <summary>
        /// 印章形状(自定义下拉列表)
        /// </summary>
        public string SealShape { get; set; }
        /// <summary>
        /// 刻制类型(自定义下拉列表)
        /// </summary>
        public string EngravingType { get; set; }
        /// <summary>
        /// 制作等级(自定义下拉列表)
        /// </summary>
        public string EngravingLevel { get; set; }


    }
}
