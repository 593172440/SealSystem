using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string ImageWidth { get; set; }
        /// <summary>
        /// 图像高度
        /// </summary>
        public string ImageHeight { get; set; }
        /// <summary>
        /// 压缩标记(图像是否压缩，1：压缩，2：不压缩)
        /// </summary>
        public string CompressTag { get; set; }
        /// <summary>
        /// 印章图像数据地址，默认为磁盘存放(但是这里要求为二进制数)
        /// </summary>
        public string ImageDataPath { get; set; }

        //------------------------------------------------

        /// <summary>
        /// 印章规格(自定义下拉列表)
        /// </summary>
        public int SealSpecification { get; set; }
        /// <summary>
        /// 印章形状(自定义下拉列表)
        /// </summary>
        public string SealShape { get; set; }
        /// <summary>
        /// 刻制类型(自定义下拉列表)
        /// </summary>
        public string EngravingType { get; set; }
        /// <summary>
        /// 制作等级(自定义下拉列表)
        /// </summary>
        public string EngravingLevel { get; set; }
    }
}
