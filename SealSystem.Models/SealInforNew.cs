﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SealSystem.Models
{
    /// <summary>
    /// 新的印章基本信息
    /// </summary>
    public class SealInforNew : BaseEntity
    {
        /// <summary>
        /// 印章编码(标准：GA 241.1)
        /// </summary>
        [Required]
        [Display(Name = "印章编码")]
        public string SealInforNum { get; set; }
        /// <summary>
        /// 印章类型代码(标准：GA 241.2)
        /// </summary>
        [ForeignKey(nameof(SealCategory))]
        public int SealCategory_Id_Code { get; set; }
        public SealCategory SealCategory { get; set; }
        /// <summary>
        /// 印章内容(默认为使用单位名称)
        /// </summary>
        public string SealContent { get; set; }
        /// <summary>
        /// 外文内容
        /// </summary>
        public string ForeignLanguageContent { get; set; }
        /// <summary>
        /// 使用单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealUseUnitInfor))]
        public int SealUseUnitInfor_Id_UnitNumber { get; set; }
        public SealUseUnitInfor SealUseUnitInfor { get; set; }
        /// <summary>
        /// 刻制类型(自定义下拉列表)
        /// </summary>
        [Display(Name = "刻制类型")]
        public string EngravingType { get; set; }
        /// <summary>
        /// 制章单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealMakingUnitInfor))]
        public int SealMakingUnitInfor_Id_MakingUnitCode { get; set; }
        public SealMakingUnitInfor SealMakingUnitInfor { get; set; }
        /// <summary>
        /// 章面材料代码(标准：GA 241.2)
        /// </summary>
        [ForeignKey(nameof(SealMaterial))]
        public int SealMaterial_Id_Code { get; set; }
        public SealMaterial SealMaterial { get; set; }
        /// <summary>
        /// 印章规格(自定义下拉列表)
        /// </summary>
        [Display(Name = "印章规格")]
        public string SealSpecification { get; set; }
        /// <summary>
        /// 登记类别
        /// </summary>
        [Display(Name = "登记类别")]
        public string RegistrationCategory { get; set; }
        /// <summary>
        /// 印章形状(自定义下拉列表)
        /// </summary>
        [Display(Name = "印章形状")]
        public string SealShape { get; set; }

        /// <summary>
        /// 制作等级(自定义下拉列表)
        /// </summary>
        [Display(Name = "制作等级")]
        public string EngravingLevel { get; set; }
        /// <summary>
        /// 印章状态(标准：GA 241.2)
        /// </summary>
        public string SealState { get; set; }

        //-------------------------------------//

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
        /// 经办人联系方式
        /// </summary>
        [Display(Name = "联系方式")]
        public string Contact { get; set; }
        /// <summary>
        /// 备案人
        /// </summary>
        [Display(Name = "备案人")]
        public string Approval { get; set; }
        /// <summary>
        /// 备案日期
        /// </summary>
        [Display(Name = "备案日期")]
        public DateTime? ApprovalTime { get; set; }
        /// <summary>
        /// 备案单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealApprovalUnitInfor))]
        public int SealApprovalUnitInfor_Id_ApprovalUnitCode { get; set; }
        public SealApprovalUnitInfor SealApprovalUnitInfor { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 制作方式(自定义下拉列表)
        /// </summary>
        public string MakeWay { get; set; }

        /// <summary>
        /// 制作人(一般为制章单位人或单位名称)
        /// </summary>
        public string TheProducer { get; set; }

    }
}