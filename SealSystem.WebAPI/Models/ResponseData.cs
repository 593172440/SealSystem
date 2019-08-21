using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Models
{
    /// <summary>
    /// 服务器响应类
    /// </summary>
    public class ResponseData
    {
        public int code { get; set; } = 200;
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}