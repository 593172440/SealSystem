using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 章面(体)材料
    /// </summary>
    public class SealMaterial:BaseEntity
    {
        /// <summary>
        /// 章面(体)材料名称
        /// </summary>
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
