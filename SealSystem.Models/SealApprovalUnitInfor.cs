using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章备案信息表
    /// </summary>
    public class SealApprovalUnitInfor:BaseEntity
    {
        /// <summary>
        /// 备案单位编码(标准：GA 241.1)
        /// </summary>
        [Display(Name = "备案单位编码")]
        public string ApprovalUnitCode { get; set; }
        /// <summary>
        /// 备案单位名称
        /// </summary>
        public string Name { get; set; }
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
        /// 联系方式
        /// </summary>
        [Display(Name = "联系方式")]
        public string Contact { get; set; }
        /// <summary>
        /// 备案人
        /// </summary>
        [Display(Name = "备案人")]
        public string Approval { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }
}
