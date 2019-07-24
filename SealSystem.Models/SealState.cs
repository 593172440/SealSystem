using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章状态代码表
    /// </summary>
    public class SealState:BaseEntity
    {
        /// <summary>
        /// 印章状态名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 印章代码
        /// </summary>
        public string Code { get; set; }
    }
}
