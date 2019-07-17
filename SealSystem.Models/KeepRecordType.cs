using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 备案类型表
    /// </summary>
    public class KeepRecordType:BaseEntity
    {
        /// <summary>
        /// 备案类型名称
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
