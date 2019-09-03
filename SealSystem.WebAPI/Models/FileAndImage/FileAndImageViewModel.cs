using System.ComponentModel.DataAnnotations;

namespace SealSystem.WebAPI.Models.FileAndImage
{
    /// <summary>
    /// 文件/图像存储
    /// </summary>
    public class FileAndImageViewModel
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string NamePath { get; set; }
        /// <summary>
        /// 是哪个印章里面的相关文件编码(印章信息外键)
        /// </summary>
        [Required]
        public string SealInforNew_SealInforNum { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }
}