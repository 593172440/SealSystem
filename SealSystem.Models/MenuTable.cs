using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class MenuTable:BaseEntity
    {
        /// <summary>
        /// 菜单号
        /// </summary>
        public int CodeId { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 上级菜单号默认为0，没有上级
        /// </summary>
        public int SuperiorCodeId { get; set; } = 0;
        /// <summary>
        /// 菜单路径
        /// </summary>
        public string MenuPath { get; set; }
        /// <summary>
        /// 增加权限
        /// </summary>
        public bool Add { get; set; }
        /// <summary>
        /// 修改权限
        /// </summary>
        public bool Edit { get; set; }
        /// <summary>
        /// 查看权限
        /// </summary>
        public bool Details { get; set; }
        /// <summary>
        /// 删除权限
        /// </summary>
        public bool Delete { get; set; }
    }
}
