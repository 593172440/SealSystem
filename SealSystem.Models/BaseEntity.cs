using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 是否被删除，伪删除
        /// </summary>
        [Display(Name = "是否删除")]
        public bool IsRemoved { get; set; } = false;
    }
}
