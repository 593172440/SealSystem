using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 单位类型表
    /// </summary>
    public class EnterpriseType:BaseEntity
    {
        /// <summary>
        /// 单位类型名称
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
