using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Dto
{
    /// <summary>
    /// 印章信息管理
    /// </summary>
    public class SealInfomationManagement
    {
        public int Id { get; set; }
        /// <summary>
        /// 印章编号
        /// </summary>
        public string SealInfor_SealInforNum { get; set; }
        /// <summary>
        /// 印章内容
        /// </summary>
        public string SealInfor_SealContent { get; set; }
        /// <summary>
        /// 印章类型
        /// </summary>
        public string SealType_Name { get; set; }
        /// <summary>
        /// 申请人!!!不知道在哪个表中!!!
        /// </summary>
        public string Applicant{ get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime SealType_CreateTime { get; set; }
        /// <summary>
        /// 印章状态!!!不知道在哪个表中！！！
        /// </summary>
        public string SealState { get; set; }
        /// <summary>
        /// 当前状态！！！不知道在哪个表中！！！
        /// </summary>
        public string CurrentState { get; set; }

    }
}
