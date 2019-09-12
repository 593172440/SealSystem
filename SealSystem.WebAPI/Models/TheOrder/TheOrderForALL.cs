using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.TheOrder
{
    /// <summary>
    /// 订单信息
    /// </summary>
    public class TheOrderForALL
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
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
        /// <summary>
        /// 印章编码
        /// </summary>
        public string SealInforNum { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}