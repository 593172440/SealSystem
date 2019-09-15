using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.SealINforNew
{
    /// <summary>
    /// 印章交付需要更新印章信息
    /// </summary>
    public class SealINforNewViewModelJiaoFu
    {
        /// <summary>
        /// 章体材料代码(标准：GA 241.2)(在SealUseUnitInforList表中定义)
        /// </summary>
        public string SealMaterial { get; set; }
        /// <summary>
        /// 制作方式(在SealUseUnitInforList表中定义)
        /// </summary>
        public string MakeWay { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }
}