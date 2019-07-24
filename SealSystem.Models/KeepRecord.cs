using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    /// <summary>
    /// 备案表
    /// </summary>
    public class KeepRecord:BaseEntity
    {
        /// <summary>
        /// 备案类型Id
        /// </summary>
        public int KeepRecordType_Id { get; set; }
        public KeepRecordType KeepRecordType { get; set; }

        /// <summary>
        /// 用户Id(制章单位？？)
        /// </summary>
        public int User_Id { get; set; }
        public User User { get; set; }


        /// <summary>
        /// 所属企业
        /// </summary>
        public int Enterpise_Id { get; set; }
        public SealUseUnitInfor Enterpise { get; set; }
    }
}
