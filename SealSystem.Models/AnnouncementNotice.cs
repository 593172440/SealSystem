using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 通知公告
    /// </summary>
    public class AnnouncementNotice:BaseEntity
    {
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 发表人
        /// </summary>
        public string UserName { get; set; }
    }
}
