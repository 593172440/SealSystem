using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.SealUseUnitInfor
{
    /// <summary>
    /// 印章使用单位信息
    /// </summary>
    public class SealUseUnitInforViewModel
    {
        /// <summary>
        /// 单位编号(标准：GA 241.1)
        /// </summary>
        [Display(Name = "单位编号")]
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
        /// 单位类型(标准：GA 241.2)(外键)
        /// </summary>
        public int SealUnitCategory_Id { get; set; }
        /// <summary>
        /// 语音查询密码
        /// </summary>
        [Display(Name = "语音查询密码")]
        public string VoiceQueryPassword { get; set; }
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


        //-----------------------------------------------------

        /// <summary>
        /// 单位分类(外键)
        /// </summary>
        public int SealUnitClass_Id { get; set; }
        /// <summary>
        /// 企业证件类型(自定义下拉列表)
        /// </summary>
        [Display(Name = "企业证件类型(自定义下拉列表)")]
        public string EnterpriseDocumentsType { get; set; }
        /// <summary>
        /// 证件号
        /// </summary>
        [Display(Name = "证件号")]
        public string IdNumbers { get; set; }
        /// <summary>
        /// 区域信息(外键)
        /// </summary>
        public int Area_Id { get; set; }
    }
}