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
        [ForeignKey(nameof(User))]
        public int User_Id { get; set; }
        public User User { get; set; }


        [ForeignKey(nameof(MenuTable))]
        public int Menu_Id { get; set; }
        public MenuTable MenuTable { get; set; }
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
