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
    public class DataToFile:BaseEntity
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件说明
        /// </summary>
        public string FileInstructions { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string NamePath { get; set; }
        /// <summary>
        /// 是哪个印章里面的相关文件编码
        /// </summary>
        public string SealInforNew_SealInforNum { get; set; }
        //备注
        public string Note { get; set; }
    }
}
