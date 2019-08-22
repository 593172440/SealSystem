using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
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
        public string EntityName { get; set; }
        /// <summary>
        /// 每个组里有多个用户(用户组外键)
        /// </summary>
        public int UserGroup_Id { get; set; }
        
    }
}