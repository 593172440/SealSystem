using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 登记类别表
    /// </summary>
    public class RegistrationClass:BaseEntity
    {
        /// <summary>
        /// 登记类别名称
        /// </summary>
        public string Name { get; set; }
    }
}
