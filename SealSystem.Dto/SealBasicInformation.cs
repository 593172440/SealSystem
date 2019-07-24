using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealSystem.Dto
{
    /// <summary>
    /// 印章基本信息
    /// </summary>
    public class SealBasicInformation
    {
        /// <summary>
        /// 印章编号
        /// </summary>
        public int SealInfor_SealInforNum { get; set; }
        /// <summary>
        /// 使用单位
        /// </summary>
        public string Enterpise_Name { get; set; }
        /// <summary>
        /// 印章类型
        /// </summary>
        public string SealType_Name { get; set; }
        /// <summary>
        /// 印章规格
        /// </summary>
        public string SealSpecification_Name { get; set; }
        /// <summary>
        /// 章面编号
        /// </summary>
        public string SealInfor_SealFrontNum { get; set; }
        /// <summary>
        /// 芯片UID
        /// </summary>
        public string UID { get; set; }
        /// <summary>
        /// 印章内容
        /// </summary>
        public string SealInfor_SealContent { get; set; }
        /// <summary>
        /// 外文内容
        /// </summary>
        public string ForeignLanguageContent { get; set; }
        /// <summary>
        /// 制章单位
        /// </summary>
        public string User_EntityName { get; set; }
        /// <summary>
        /// 其它内容
        /// </summary>
        public string SealInfor_SealOtherContent { get; set; }
        /// <summary>
        /// 登记类别
        /// </summary>
        public string RegistrationClass_Name { get; set; }
        /// <summary>
        /// 印章形状
        /// </summary>
        public string SealShape_Name { get; set; }
        /// <summary>
        /// 刻制类型
        /// </summary>
        public string EngravingType_Name { get; set; }
        /// <summary>
        /// 制作等级
        /// </summary>
        public string EngravingLevel_Name { get; set; }
        /// <summary>
        /// 章体材料
        /// </summary>
        public string SealMaterial_Name { get; set; }
        /// <summary>
        /// 印章图片
        /// </summary>
        public string SealType_Pic { get; set; }

    }
}
