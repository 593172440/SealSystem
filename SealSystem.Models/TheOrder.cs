using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class TheOrder:BaseEntity
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string TheOrderCode { get; set; }
        /// <summary>
        /// 登记区域
        /// </summary>
        public string TheRegistrationArea { get; set; }
        /// <summary>
        /// 制章单位名称
        /// </summary>
        public string SealMakingUnitInfor_Name { get; set; }
        /// <summary>
        /// 备案类型(在SealUseUnitInforList表中定义)
        /// </summary>
        public string ForTheRecordType { get; set; }
    }
}
