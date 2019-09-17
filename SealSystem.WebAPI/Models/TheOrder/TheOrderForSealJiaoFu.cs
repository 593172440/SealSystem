using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.TheOrder
{
    /// <summary>
    /// 印章交付取章人信息
    /// </summary>
    public class TheOrderForSealJiaoFu
    {
        /// <summary>
        /// 取章人姓名
        /// </summary>
        public string TakeSealName { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCard { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string SealState { get; set; }
    }
}