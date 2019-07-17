using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{   
    /// <summary>
    /// 企业证件类型表
    /// </summary>
    public class EnterpriseDocumentsType : BaseEntity
    {
        /// <summary>
        /// 企业证件类型名称
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
