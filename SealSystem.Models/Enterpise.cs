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
    /// 企业表
    /// </summary>
    public class Enterpise:BaseEntity
    {
        /// <summary>
        /// 单位名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 民族文字
        /// </summary>
        public string NationalCharacters { get; set; }
        /// <summary>
        /// 企业英文名
        /// </summary>
        public string EnglishName { get; set; }
        /// <summary>
        /// 企业法人
        /// </summary>
        [Required]
        public string LegelPerson { get; set; }
        /// <summary>
        /// 企业法人身份证号
        /// </summary>
        [Required]
        [StringLength(18)]
        public string IdNumber { get; set; }
        /// <summary>
        /// 法人电话
        /// </summary>
        [Required]
        public string LegelPhone { get; set; }
        /// <summary>
        /// 企业证件号
        /// </summary>
        [Required]
        public string EnterpriseDocuments { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        [Required]
        public string EnterpriseAddress { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 单位类型
        /// </summary>
        [ForeignKey(nameof(EnterpriseType))]
        public int EnterpriseType_Id { get; set; }
        public EnterpriseType EnterpriseType { get; set; }
        /// <summary>
        /// 单位分类
        /// </summary>
        [ForeignKey(nameof(EnterpriseClass))]
        public int EnterpriseClass_Id { get; set; }
        public EnterpriseClass EnterpriseClass { get; set; }

        /// <summary>
        /// 企业证件类型
        /// </summary>
        [ForeignKey(nameof(EnterpriseDocumentsType))]
        public int EnterpriseDocumentsType_Id { get; set; }
        public EnterpriseDocumentsType EnterpriseDocumentsType { get; set; }
    }
}
