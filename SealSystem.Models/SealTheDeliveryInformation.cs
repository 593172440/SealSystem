using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace SealSystem.Models
{
    /// <summary>
    /// 印章交付信息表
    /// </summary>
    public class SealTheDeliveryInformation:BaseEntity
    {
        
        /// <summary>
        /// 制章单位编码(标准：GA 241.1)
        /// </summary>
        [ForeignKey(nameof(SealMakingUnitInfor))]
        public int SealMakingUnitInfor_Id_MakingUnitCode { get; set; }
        public SealMakingUnitInfor SealMakingUnitInfor { get; set; }

        
        /// <summary>
        /// 取章人姓名
        /// </summary>
        public string TakeSealName { get; set; }
        /// <summary>
        /// 取章日期
        /// </summary>
        public DateTime? TakeTime { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCard { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 交付日期
        /// </summary>
        public DateTime? DeliveryTime { get; set; }
        /// <summary>
        /// 上传日期
        /// </summary>
        public DateTime? UpTime { get; set; }
    }
}
