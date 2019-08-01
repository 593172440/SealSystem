using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Models
{
    public class FileAndImage:BaseEntity
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string NamePath { get; set; }
        /// <summary>
        /// 是哪个印章里面的相关文件
        /// </summary>
        [ForeignKey(nameof(SealInfor))]
        public int? SealInfor_Id { get; set; }
        public SealInfor SealInfor { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }
}
