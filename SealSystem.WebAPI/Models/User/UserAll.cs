using System;
using System.ComponentModel.DataAnnotations;

namespace SealSystem.WebAPI.Models.User
{
    public class UserAll
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [StringLength(50)]
        public string UserPwd { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        [Display(Name = "单位名称(汉字)")]
        public string EntityName { get; set; }
        /// <summary>
        /// 单位编码(标准：GA241.1)
        /// </summary>
        [Display(Name = "单位编码")]
        public string UnitCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "单位编码")]
        public string Note { get; set; }
        /// <summary>
        /// 每个组里有多个用户(用户组外键)
        /// </summary>
        public int UserGroup_Id { get; set; }

        //------------------------------->印章制作单位信息表

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
        [Display(Name = "法定代表人(负责人)")]
        public string LegelPerson { get; set; }
        /// <summary>
        /// 法定代表人(负责人)身份证号
        /// </summary>
        [StringLength(18)]
        [Display(Name = "法定代表人(负责人)身份证号")]
        public string IdNumber { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
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


        //------------->印章备案信息表

        /// <summary>
        /// 经办人
        /// </summary>
        [Display(Name = "经办人")]
        public string Attention { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Display(Name = "身份证")]
        public string AttentionIdCard { get; set; }

        /// <summary>
        /// 备案人
        /// </summary>
        [Display(Name = "备案人")]
        public string Approval { get; set; }
    }
}