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
    /// 印章信息表
    /// </summary>
    public class SealInfor:BaseEntity
    {
        /// <summary>
        /// 印章编号
        /// </summary>
        [Required]
        public int SealInforNum { get; set; }
        /// <summary>
        /// 章面编号
        /// </summary>
        public int SealFrontNum { get; set; }
        /// <summary>
        /// 印章内容
        /// </summary>
        public string SealContent { get; set; }
        /// <summary>
        /// 印章其它内容
        /// </summary>
        public string SealOtherContent { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 印章形状Id
        /// </summary>
        [ForeignKey(nameof(SealShape))]
        public int SealShape_Id { get; set; }
        public SealShape SealShape { get; set; }
        /// <summary>
        /// 章体材料id
        /// </summary>
        [ForeignKey(nameof(SealMaterial))]
        public int SealMaterial_Id { get; set; }
        public SealMaterial SealMaterial { get; set; }
        /// <summary>
        /// 刻章类型id
        /// </summary>
        [ForeignKey(nameof(EngravingType))]
        public int EngravingType_Id { get; set; }
        public EngravingType EngravingType { get; set; }
        /// <summary>
        /// 制作等级id
        /// </summary>
        [ForeignKey(nameof(EngravingLevel))]
        public int EngravingLevel_Id { get; set; }
        public EngravingLevel EngravingLevel { get; set; }
        /// <summary>
        /// 登记类别
        /// </summary>
        [ForeignKey(nameof(RegistrationClass))]
        public int RegistrationClass_Id { get; set; }
        public RegistrationClass RegistrationClass { get; set; }
        /// <summary>
        /// 所属备案
        /// </summary>
        [ForeignKey(nameof(KeepRecord))]
        public int KeepRecord_Id { get; set; }
        public KeepRecord KeepRecord { get; set; }
    }
}
