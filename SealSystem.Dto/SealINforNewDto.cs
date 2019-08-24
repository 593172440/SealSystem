using System;

namespace SealSystem.Dto
{
    /// <summary>
    /// 印章信息
    /// </summary>
    public class SealInforNewDto
    {
        /// <summary>
        /// 印章编码(标准：GA 241.1)
        /// </summary>
        public string SealInforNum { get; set; }
        /// <summary>
        /// 印章类型代码(标准：GA 241.2)(SealCategory外键)
        /// </summary>
        public int SealCategory_Id_Code { get; set; }
        /// <summary>
        /// 印章内容(默认为使用单位名称)
        /// </summary>
        public string SealContent { get; set; }
        /// <summary>
        /// 外文内容
        /// </summary>
        public string ForeignLanguageContent { get; set; }
        /// <summary>
        /// 使用单位编码(标准：GA 241.1)(SealUseUnitInfor外键)
        /// </summary>
        public int SealUseUnitInfor_Id_UnitNumber { get; set; }
        /// <summary>
        /// 刻制类型(自定义下拉列表)
        /// </summary>
        public string EngravingType { get; set; }
        /// <summary>
        /// 制章单位编码(标准：GA 241.1)(SealMakingUnitInfor外键)
        /// </summary>
        public int SealMakingUnitInfor_Id_MakingUnitCode { get; set; }
        /// <summary>
        /// 章面材料代码(标准：GA 241.2)(SealMaterial外键)
        /// </summary>
        public int SealMaterial_Id_Code { get; set; }

        /// <summary>
        /// 登记类别
        /// </summary>
        public string RegistrationCategory { get; set; }
        /// <summary>
        /// 印章形状(自定义下拉列表)
        /// </summary>
        public string SealShape { get; set; }

        /// <summary>
        /// 制作等级(自定义下拉列表)
        /// </summary>
        public string EngravingLevel { get; set; }
        /// <summary>
        /// 印章状态(标准：GA 241.2)
        /// </summary>
        public string SealState { get; set; }

        //-------------------------------------//

        /// <summary>
        /// 经办人(申请人)
        /// </summary>
        public string Attention { get; set; }
        /// <summary>
        /// 经办人身份证
        /// </summary>
        public string AttentionIdCard { get; set; }
        /// <summary>
        /// 经办人联系方式
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// 备案人
        /// </summary>
        public string Approval { get; set; }
        /// <summary>
        /// 备案日期
        /// </summary>
        public DateTime? ApprovalTime { get; set; }
        /// <summary>
        /// 备案单位编码(标准：GA 241.1)(SealApprovalUnitInfor外键)
        /// </summary>
        public int SealApprovalUnitInfor_Id_ApprovalUnitCode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 制作方式(自定义下拉列表)
        /// </summary>
        public string MakeWay { get; set; }

        /// <summary>
        /// 制作人(一般为制章单位人或单位名称)
        /// </summary>
        public string TheProducer { get; set; }

    }
}