using System.ComponentModel.DataAnnotations;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章图像信息表
    /// </summary>
    public class SealImageData:BaseEntity
    {
        /// <summary>
        /// 图像宽度
        /// </summary>
        [Display(Name = "图像宽度")]
        public string ImageWidth { get; set; }
        /// <summary>
        /// 图像高度
        /// </summary>
        [Display(Name = "图像高度")]
        public string ImageHeight { get; set; }
        /// <summary>
        /// 压缩标记(图像是否压缩，1：压缩，2：不压缩)
        /// </summary>
        [Display(Name = "压缩标记")]
        public string CompressTag { get; set; }
        /// <summary>
        /// 印章图像数据地址，默认为磁盘存放(但是这里要求为二进制数)
        /// </summary>
        [Display(Name = "印章图像数据地址")]
        public string ImageDataPath { get; set; }

       
    }
}
