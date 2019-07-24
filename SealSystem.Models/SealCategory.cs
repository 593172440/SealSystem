using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章类型表(登记类别)
    /// </summary>
    public class SealCategory:BaseEntity
    {
        /// <summary>
        /// 印章类型名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 印章类型代码
        /// </summary>
        public string Code { get; set; }
    }
}
