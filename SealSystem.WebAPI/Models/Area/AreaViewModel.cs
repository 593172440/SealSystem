using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.Area
{
    /// <summary>
    /// 地区区域
    /// </summary>
    public class AreaViewModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 区域代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 地区名
        /// </summary>
        public string Name { get; set; }
    }
}