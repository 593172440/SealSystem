using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章形状表
    /// </summary>
    public class SealShape:BaseEntity
    {
        /// <summary>
        /// 印章形状名称
        /// </summary>
        public string Name { get; set; }
    }
}
