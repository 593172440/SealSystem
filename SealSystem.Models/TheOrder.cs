﻿using System;
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
        /// <summary>
        /// 订单状态
        /// </summary>
        public string SealState { get; set; }
    }
}
