using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章基本信息表
    /// </summary>
    public class SealInfor:BaseEntity
    {
        /// <summary>
        /// 印章编码(标准：GA 241.1)
        /// </summary>
        [Required]
        [Display(Name = "印章编码")]
        public string SealInforNum { get; set; }
        /// <summary>
        /// 印章名称(内容)
        /// </summary>
        [Display(Name = "印章名称(内容)")]
        public string SealName { get; set; }
        /// <summary>
        /// 印章状态代码(标准：GA 241.2)
        /// </summary>
        public string SealState { get; set; }
        /// <summary>
        /// 使用单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealUseUnitInfor))]
        public int SealUseUnitInfor_Id_UnitNumber { get; set; }
        public SealUseUnitInfor SealUseUnitInfor { get; set; }
        /// <summary>
        /// 备案单位编码(标准：GA 241.1)
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
        [Display(Name = "印油说明")]
        public string ManyInstructions { get; set; }
        /// <summary>
        /// 经办人(申请人)
        /// </summary>
        [Display(Name = "经办人(申请人)")]
        public string Attention { get; set; }
        /// <summary>
        /// 经办人身份证
        /// </summary>
        [Display(Name = "经办人身份证")]
        public string AttentionIdCard { get; set; }
        /// <summary>
        /// 备案人
        /// </summary>
        [Display(Name = "备案人")]
        public string Approval{ get; set; }
        /// <summary>
        /// 备案日期
        /// </summary>
        [Display(Name = "备案日期")]
        public DateTime? ApprovalTime { get; set; }
        /// <summary>
        /// 承接日期
        /// </summary>
        [Display(Name = "承接日期")]
        public DateTime? UndertakeTime { get; set; }
        /// <summary>
        /// 制作日期
        /// </summary>
        [Display(Name = "制作日期")]
        public DateTime? MakingTime { get; set; }
        /// <summary>
        /// 交付日期
        /// </summary>
        [Display(Name = "交付日期")]
        public DateTime? DeliveryTime { get; set; }
        /// <summary>
        /// 报废日期
        /// </summary>
        [Display(Name = "报废日期")]
        public DateTime? ScrapTime { get; set; }
        /// <summary>
        /// 缴销日期
        /// </summary>
        [Display(Name = "缴销日期")]
        public DateTime? HandTime { get; set; }
        /// <summary>
        /// 挂失日期
        /// </summary>
        [Display(Name = "挂失日期")]
        public DateTime? LossTime { get; set; }
        /// <summary>
        /// 最后年检日期
        /// </summary>
        [Display(Name = "最后年检日期")]
        public DateTime? LastAnnualTime { get; set; }
        /// <summary>
        /// 图像宽度
        /// </summary>
        [Display(Name = "图像宽度")]
        public string ImageWidth { get; set; }
        /// <summary>
        /// 图像高度
        /// </summary>
        [Display(Name = "图像高度")]
        public string ImageHeight { get; set; }
        /// <summary>
        /// 压缩标记(图像是否压缩，1：压缩，2：不压缩)
        /// </summary>
        [Display(Name = "压缩标记")]
        public string CompressTag { get; set; }
        /// <summary>
        /// 印章图像数据地址，默认为磁盘存放(但是这里要求为二进制数)
        /// </summary>
        [Display(Name = "印章图像数据地址")]
        public string ImageDataPath { get; set; }
        

        //------------------------------------------------

        /// <summary>
        /// 印章形状(自定义下拉列表)
        /// </summary>
        [Display(Name = "印章形状")]
        public string SealShape { get; set; }
        /// <summary>
        /// 刻制类型(自定义下拉列表)
        /// </summary>
        [Display(Name = "刻制类型")]
        public string EngravingType { get; set; }
        /// <summary>
        /// 制作等级(自定义下拉列表)
        /// </summary>
        [Display(Name = "制作等级")]
        public string EngravingLevel { get; set; }
        /// <summary>
        /// 登记类别
        /// </summary>
        [Display(Name = "登记类别")]
        public string RegistrationCategory { get; set; }

    }
}
