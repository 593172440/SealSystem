using System.ComponentModel.DataAnnotations;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章类型规格表表(登记类别)
    /// </summary>
    public class SealCategory:BaseEntity
    {
        /// <summary>
        /// 印章类型名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 印章类型代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 印章规格名称
        /// </summary>
        public string SealSpecifications { get; set; }
        /// <summary>
        /// 测试印章图片地址
        /// </summary>
        public string TestImagePath { get; set; }
    }
}
