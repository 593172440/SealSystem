using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.Web3.Models
{
    public class SealInforNew2
    {
        public string SealUseUnitInfor_Id_UnitNumber { get; set; }
        public string SealState { get; set; }
        public string SealApprovalUnitInfor_Id_ApprovalUnitCode { get; set; }
        public string SealMakingUnitInfor_Id_MakingUnitCode { get; set; }
        public string ApprovalTime { get; set; }
        public string Attention { get; set; }
        public string AttentionIdCard { get; set; }
        public string Approval { get; set; }
        public string ForeignLanguageContent { get; set; }
    }
}