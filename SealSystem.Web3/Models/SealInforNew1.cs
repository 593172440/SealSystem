using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.Web3.Models
{
    public class SealInforNew1
    {
        public string SealInforNum { get; set; }
        public string SealContent { get; set; }
        public string SealMaterial { get; set; }
        public string Note { get; set; }
        /// <summary>
        /// 印章规格
        /// </summary>
        public string SealSpecification { get; set; }
        public string EngravingLevel { get; set; }
        public string RegistrationCategory { get; set; }
        public string SealCategory_Id_Code { get; set; }
        public string SealShape { get; set; }
        public string EngravingType { get; set; }
        public string form_index { get; set; }
    }
}