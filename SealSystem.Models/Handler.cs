using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 经办人表
    /// </summary>
    public class Handler:BaseEntity
    {
        /// <summary>
        /// 经办人名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 经办人身份证号
        /// </summary>
        [Required]
        [StringLength(18)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 备案人名称
        /// </summary>
        [StringLength(50)]
        public string RecorderName { get; set; }
        /// <summary>
        /// 备案日期
        /// </summary>
        public DateTime RecordDate { get; set; }
        /// <summary>
        /// 备案单位
        /// </summary>
        public string RecordOrg { get; set; }
        /// <summary>
        /// 备案方式
        /// </summary>
        public string DeliveryMode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }



        /// <summary>
        /// 所属备案Id
        /// </summary>
        [ForeignKey(nameof(KeepRecord))]
        public int KeepRecord_Id { get; set; }
        public KeepRecord KeepRecord { get; set; }

    }
}
