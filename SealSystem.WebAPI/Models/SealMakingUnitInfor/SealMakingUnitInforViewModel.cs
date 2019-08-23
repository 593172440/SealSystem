using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.SealMakingUnitInfor
{
    /// <summary>
    /// 印章制作单位信息表
    /// </summary>
    public class SealMakingUnitInforViewModel
    {
        /// <summary>
        /// 制作单位编码(标准：GA241.1)
        /// </summary>
        [Display(Name = "单位编号")]
        public string MakingUnitCode { get; set; }
        /// <summary>
        /// 单位名称(汉字)
        /// </summary>
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
        /// 法定代表人(负责人)
        /// </summary>
        [Required]
        [Display(Name = "法定代表人(负责人)")]
        public string LegelPerson { get; set; }
        /// <summary>
        /// 法定代表人(负责人)身份证号
        /// </summary>
        [Required]
        [StringLength(18)]
        [Display(Name = "法定代表人(负责人)身份证号")]
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
        /// 邮政编码
        /// </summary>
        [Display(Name = "邮政编码")]
        public string TheZipCode { get; set; }

        //--------------------------------------------------

        /// <summary>
        /// 联系人
        /// </summary>
        [Display(Name = "联系人")]
        public string Contact { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
        [Display(Name = "联系人电话")]
        public string ContanctPhone { get; set; }
        /// <summary>
        /// 营业执照
        /// </summary>
        [Display(Name = "营业执照")]
        public string BusinessLicense { get; set; }
        /// <summary>
        /// 营业状态
        /// </summary>
        [Display(Name = "营业状态")]
        public string BusinessState { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remarks { get; set; }
    }
}