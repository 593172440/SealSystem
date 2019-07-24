using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章规格表
    /// </summary>
    public class SealSpecification:BaseEntity
    {
        /// <summary>
        /// 印章规格名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 印章类型Id
        /// </summary>
        [ForeignKey(nameof(SealType))]
        public int SealType_Id { get; set; }
        public SealCategory SealType { get; set; }
      
    }
}
