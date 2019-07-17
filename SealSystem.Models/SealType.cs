using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章类型表
    /// </summary>
    public class SealType:BaseEntity
    {
        /// <summary>
        /// 印章类型名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 印章类型图片
        /// </summary>
        public string Pic { get; set; }
    }
}
