using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章基本信息
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
        /// 使用单位编码(标准：GA 241.1)(外键)
        /// </summary>
        [ForeignKey(nameof(SealUseUnitInfor))]
        public int SealUseUnitInfor_Id_UnitNumber { get; set; }
        public SealUseUnitInfor SealUseUnitInfor { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string TheOrders_TheOrderCode { get; set; }
        /// <summary>
        /// 用户信息id
        /// </summary>
        public int User_Id { get; set; }

        /// <summary>
        /// 印章类型代码(标准：GA 241.2)(外键)
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
        /// 章体材料代码(标准：GA 241.2)(在SealUseUnitInforList表中定义)
        /// </summary>
        public string SealMaterial { get; set; }
        /// <summary>
        /// 登记类别
        /// </summary>
        [Display(Name = "登记类别")]
        public string RegistrationCategory { get; set; }
        /// <summary>
        /// 印章形状(在SealUseUnitInforList表中定义)
        /// </summary>
        [Display(Name = "印章形状")]
        public string SealShape { get; set; }
        /// <summary>
        /// 刻制类型(在SealUseUnitInforList表中定义)
        /// </summary>
        [Display(Name = "刻制类型")]
        public string EngravingType { get; set; }
        /// <summary>
        /// 制作等级(在SealUseUnitInforList表中定义)
        /// </summary>
        [Display(Name = "制作等级")]
        public string EngravingLevel { get; set; }
        /// <summary>
        /// 印章状态(标准：GA 241.2)(在SealUseUnitInforList表中定义)
        /// </summary>
        public string SealState { get; set; }

        //-------------------------------------//
        /// <summary>
        /// 制作方式(在SealUseUnitInforList表中定义)
        /// </summary>
        public string MakeWay { get; set; }

        /// <summary>
        /// 制作人(一般为制章单位人或单位名称)
        /// </summary>
        public string TheProducer { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

    }
}
