using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 上传文件管理表
    /// </summary>
    public class DataFile:BaseEntity
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件说明
        /// </summary>
        public string FileInstructions { get; set; }
        //备注
        public string Note { get; set; }
    }
}
