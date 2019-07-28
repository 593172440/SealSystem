using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章备案(审批)单位信息表
    /// </summary>
    public class SealApprovalUnitInfor:BaseEntity
    {
        /// <summary>
        /// 备案单位编码(标准：GA 241.1)
        /// </summary>
        [Display(Name = "备案单位编码")]
        public string ApprovalUnitCode { get; set; }
        /// <summary>
        /// 单位名称(汉字)
        /// </summary>
        [Required]
        [Display(Name = "单位名称(汉字)")]
        public string Name { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        [Display(Name = "负责人")]
        public string LegelPerson { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        [Required]
        [Display(Name = "单位地址")]
        public string UnitAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [Required]
        [Display(Name = "电话")]
        public string Phone { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        [Display(Name = "邮政编码")]
        public string TheZipCode { get; set; }
    }
}
