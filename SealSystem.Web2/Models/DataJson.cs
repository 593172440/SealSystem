using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.Web2.Models
{
    public class DataJson
    {
        public int code { get; set; } = 0;
        public string msg { get; set; } = "";
        public int count { get; set; }
        public object[] data { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}