using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章审批单位信息表
    /// </summary>
    public class SealApprovalUnitInfor:BaseEntity
    {
        /// <summary>
        /// 审批单位编码(标准：GA 241.1)
        /// </summary>
        public string ApprovalUnitCode { get; set; }
        /// <summary>
        /// 单位名称(汉字)
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string LegelPerson { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        [Required]
        public string UnitAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [Required]
        public string Phone { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string TheZipCode { get; set; }
    }
}
