using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 用户权限表
    /// </summary>
    public class UserPermissions:BaseEntity
    {
        /// <summary>
        /// 每个组有许多权限
        /// </summary>
        [ForeignKey(nameof(UserGroup))]
        public int UserGroup_Id { get; set; }
        public UserGroup UserGroup { get; set; }

        /// <summary>
        /// 菜单编号
        /// </summary>
       public int MenuTables_CodeId { get; set; }
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
