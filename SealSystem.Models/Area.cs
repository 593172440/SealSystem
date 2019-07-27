using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 地区区域表
    /// </summary>
    public class Area:BaseEntity
    {
        /// <summary>
        /// 区域代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 地区名
        /// </summary>
        public string Name { get; set; }
    }
}
