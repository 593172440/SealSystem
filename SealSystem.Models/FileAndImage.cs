using System.ComponentModel.DataAnnotations.Schema;

namespace SealSystem.Models
{
    /// <summary>
    /// 文件图像存储表
    /// </summary>
    public class FileAndImage:BaseEntity
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string NamePath { get; set; }
        /// <summary>
        /// 是哪个印章里面的相关文件编码
        /// </summary>
        public string SealInforNew_SealInforNum { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }
}
