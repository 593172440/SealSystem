using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章规格表(里面包括印章类型和印章规格)
    /// </summary>
    public class SealSpecification:BaseEntity
    {
       
        /// <summary>
        /// 印章规格
        /// </summary>
        public string SealSpecifications { get; set; }
        /// <summary>
        /// 测试印章图片地址
        /// </summary>
        public string TestImagePath { get; set; }
        /// <summary>
        /// 印章类型外键
        /// </summary>
        [ForeignKey(nameof(SealCategory))]
        public int SealCategory_Id { get; set; }
        public SealCategory SealCategory { get; set; }
    }
}
