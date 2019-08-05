using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 用户组表
    /// </summary>
    public class UserGroup:BaseEntity
    {
        /// <summary>
        /// 用户组名称
        /// </summary>
        public string Name { get; set; }
    }
}
