using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章使用单位类型表
    /// </summary>
    public class SealUnitCategory:BaseEntity
    {
        /// <summary>
        /// 单位类型名称
        /// </summary>
        [Required]
        [Display(Name="单位类型")]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
