using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 印章制作单位信息表
    /// </summary>
    public class SealMakingUnitInfor:BaseEntity
    {
        /// <summary>
        /// 制作单位编码(标准：GA241.1)
        /// </summary>
        public string MakingUnitCode { get; set; }
        /// <summary>
        /// 单位名称(汉字)
        /// </summary>
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

    }
}
