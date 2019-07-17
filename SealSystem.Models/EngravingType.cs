using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 刻章类型表
    /// </summary>
    public class EngravingType:BaseEntity
    {
        /// <summary>
        /// 刻章类型名称
        /// </summary>
        public string Name { get; set; }
    }
}
