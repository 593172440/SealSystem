using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Dto
{
    /// <summary>
    /// 使用单位信息管理列表
    /// </summary>
    public class EnterpiseInfomationManagement
    {
        /// <summary>
        /// 使用单位编号
        /// </summary>
        public string EnterpiseNumber { get; set; }
        /// <summary>
        /// 使用单位名称
        /// </summary>
        public string EnterpiseName { get; set; }
        /// <summary>
        /// 所属区域
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 企业类型
        /// </summary>
        public string EnterpriseType { get; set; }
        /// <summary>
        /// 企业法人
        /// </summary>
        public string LegelPerson { get; set; }
        /// <summary>
        /// 法人身份证
        /// </summary>
        public string IdNumber { get; set; }
        /// <summary>
        /// 备案日期
        /// </summary>
        public DateTime CreateTime { get; set; }

    }
}
