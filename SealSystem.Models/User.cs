using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User:BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(50)]
        public string UserPwd { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        [Required]
        public string EntityName { get; set; }
        /// <summary>
        /// 每个组里有多个用户(用户组外键)
        /// </summary>
        [ForeignKey(nameof(UserGroup))]
        public int UserGroup_Id { get; set; }
        public UserGroup UserGroup { get; set; }

    }
}
