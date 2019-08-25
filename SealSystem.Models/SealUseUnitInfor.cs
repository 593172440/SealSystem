using System.ComponentModel.DataAnnotations;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章使用单位信息表
    /// </summary>
    public class SealUseUnitInfor : BaseEntity
    {
        /// <summary>
        /// 单位编号(标准：GA 241.1)
        /// </summary>
        [Display(Name ="单位编号")]
        public string UnitNumber { get; set; }
        /// <summary>
        /// 单位名称(汉字)
        /// </summary>
        [Required]
        [Display(Name = "单位名称(汉字)")]
        public string Name { get; set; }
        /// <summary>
        /// 单位名称(少数民族文字)
        /// </summary>
        [Display(Name = "单位名称(少数民族文字)")]
        public string EthnicMinoritiesName { get; set; }
        /// <summary>
        /// 单位名称(英文名)
        /// </summary>
        [Display(Name = "单位名称(英文名)")]
        public string EnglishName { get; set; }
        /// <summary>
        /// 企业法人
        /// </summary>
        [Required]
        [Display(Name = "企业法人")]
        public string LegelPerson { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        [Required]
        [StringLength(18)]
        [Display(Name = "身份证号")]
        public string IdNumber { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        [Required]
        [Display(Name = "单位地址")]
        public string UnitAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [Display(Name = "电话")]
        public string Phone { get; set; }
        /// <summary>
        /// 证件号
        /// </summary>
        [Display(Name = "证件号")]
        public string IdNumbers { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Note { get; set; }

        /// <summary>
        /// 单位分类(在SealUseUnitInforList表中定义)
        /// </summary>
        [Display(Name = "单位分类")]
        public string UnitClassification { get; set; }
        /// <summary>
        /// 企业证件类型(在SealUseUnitInforList表中定义)
        /// </summary>
        [Display(Name = "企业证件类型")]
        public string EnterpriseDocumentsType { get; set; }
        /// <summary>
        /// 单位类型(在SealUseUnitInforList表中定义)
        /// </summary>
        [Display(Name = "单位类型")]
        public string TheUnitType { get; set; }
    }
}
