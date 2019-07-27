using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 单位分类表
    /// </summary>
    public class SealUnitClass:BaseEntity
    {
        /// <summary>
        /// 单位分类名称
        /// </summary>
        [Required]
        [Display(Name ="单位分类名称")]
        public string Name { get; set; }
    }
}
