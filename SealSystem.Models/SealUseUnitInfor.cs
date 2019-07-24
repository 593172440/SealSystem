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
    /// 印章使用单位信息表
    /// </summary>
    public class SealUseUnitInfor : BaseEntity
    {
        /// <summary>
        /// 单位编号(标准：GA 241.1)
        /// </summary>
        public string UnitNumber { get; set; }
        /// <summary>
        /// 单位名称(汉字)
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 单位名称(少数民族文字)
        /// </summary>
        public string EthnicMinoritiesName { get; set; }
        /// <summary>
        /// 单位名称(英文名)
        /// </summary>
        public string EnglishName { get; set; }
        /// <summary>
        /// 单位类型(标准：GA 241.2)
        /// </summary>
        [ForeignKey(nameof(SealUnitCategory))]
        public int EnterpriseType_Id { get; set; }
        public SealUnitCategory SealUnitCategory { get; set; }
        /// <summary>
        /// 语音查询密码
        /// </summary>
        public string VoiceQueryPassword { get; set; }
        /// <summary>
        /// 法定代表人(负责人)
        /// </summary>
        [Required]
        public string LegelPerson { get; set; }
        /// <summary>
        /// 法定代表人(负责人)身份证号
        /// </summary>
        [Required]
        [StringLength(18)]
        public string IdNumber { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        [Required]
        public string UnitAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string TheZipCode { get; set; }


        //-----------------------------------------------------

        /// <summary>
        /// 单位分类
        /// </summary>
        [ForeignKey(nameof(SealUnitClass))]
        public int SealUnitClass_Id { get; set; }
        public SealUnitClass SealUnitClass { get; set; }
        /// <summary>
        /// 企业证件类型
        /// </summary>
        [ForeignKey(nameof(SealUnitClass))]
        public int EnterpriseDocumentsType_Id { get; set; }
        public EnterpriseDocumentsType EnterpriseDocumentsType { get; set; }
        /// <summary>
        /// 证件号
        /// </summary>
        public string IdNumbers { get; set; }

    }
}
