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
    }
}
