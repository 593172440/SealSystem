using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Dto
{
    /// <summary>
    /// 企业详细信息(查看界面)
    /// </summary>
    public class EnterpriseDetails
    {
        /// <summary>
        /// 企业编号
        /// </summary>
        public string EnterpiseNumber { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string EnterpiseName { get; set; }
        /// <summary>
        /// 民族文字
        /// </summary>
        public string NationalCharacters { get; set; }
        /// <summary>
        /// 企业英文名
        /// </summary>
        public string EnglishName { get; set; }
        /// <summary>
        /// 单位分类
        /// </summary>
        public string EnterpriseClass { get; set; }
        /// <summary>
        /// 单位类型
        /// </summary>
        public string EnterpriseType { get; set; }
        /// <summary>
        /// 企业法人
        /// </summary>
        public string LegelPerson { get; set; }
        /// <summary>
        /// 企业法人身份证号
        /// </summary>
        public string IdNumber { get; set; }
        /// <summary>
        /// 法人电话
        /// </summary>
        public string LegelPhone { get; set; }
        /// <summary>
        /// 企业证件类型
        /// </summary>
        public string EnterpriseDocumentsType { get; set; }
        /// <summary>
        /// 企业证件号
        /// </summary>
        public string EnterpriseDocuments { get; set; }
        /// <summary>
        /// 单位地址
        /// </summary>
        public string EnterpriseAddress { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
